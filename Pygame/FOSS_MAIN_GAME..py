import sys
from random import randint,choice
import pygame
import sys
from languagelogic import prompt_word,options,ans,start_new_round

class Player(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.image = pygame.image.load('graphics/Player/player_stand.png').convert_alpha()
        self.image = pygame.transform.rotozoom(self.image,0,1.75)
        self.rect = self.image.get_rect(center = (600,501))
        self.gravity = 0
        self.player_speed = 0
        self.clicked = False
    def player_input(self):
        keys = pygame.key.get_pressed()
        if keys[pygame.K_SPACE] and self.rect.centery == 501:
            self.gravity = -32
        if keys[pygame.K_a] and self.rect.x != -3:
            self.player_speed += 4
            self.rect.x -= self.player_speed
        if keys[pygame.K_a] == False:
            self.player_speed = 0
        if keys[pygame.K_d] and self.rect.x != 1169:
            self.player_speed += 4
            self.rect.x += self.player_speed
        if keys[pygame.K_d] == False:
            self.player_speed = 0
        if pygame.mouse.get_pressed()[0] == True :
            self.clicked = True
        if pygame.mouse.get_pressed()[0] == False and self.clicked == True:
            if len(bullet) < 10:
                bullet.add(Bullet(pygame.mouse.get_pos()[0],pygame.mouse.get_pos()[1]))
                #bullet.add(Bullet(self.rect.centerx+30,self.rect.centery))
            self.clicked = False
    def apply_gravity(self):
        self.gravity += 1
        self.rect.bottom += self.gravity
        if self.rect.centery >= 501:
            self.rect.centery = 501
    def make_bullet(self):
        return Bullet(pygame.mouse.get_pos()[0],pygame.mouse.get_pos()[1])
    def update(self) :
        self.apply_gravity()
        self.player_input()
        if game_active == False:
            self.rect = self.image.get_rect(midbottom=(200, 300))

class Bullet(pygame.sprite.Sprite):
    def __init__(self,posx,posy):
        super().__init__()
        self.image = pygame.image.load('graphics/bullet.png')
        self.image = pygame.transform.rotozoom(self.image,0,1.5)
        self.rect = self.image.get_rect(center = (posx,posy))
    def update(self):
        self.rect.x += 7
        if self.rect.x >= screen_width + 20:
            self.kill()

class Enemy(pygame.sprite.Sprite):
    def __init__(self,posx,posy):
        super().__init__()
        self.image = pygame.image.load('graphics/Fly/Fly1.png').convert_alpha()
        self.image = pygame.transform.rotozoom(self.image, 0,2)
        self.rect = self.image.get_rect(center = (posx,posy))
        self.gravity = -20
        self.direction = choice(["left", "right"])
        self.word_attached = ""
    def move(self):
        if self.rect.x >= 1188:
            self.direction = "left"
        if self.direction == "left":
            self.rect.x -= 5
        if self.rect.x <= -110:
            self.direction = "right"
        if self.direction == "right":
            self.rect.x += 5
    def update(self):
        self.move()
        return self.word_attached
    def get_direction(self):
        return self.direction
    def assign_word(self,attach_word):
        self.word_attached = attach_word


class Words(pygame.sprite.Sprite):
    def __init__(self, posx, posy,option,direction):
        super().__init__()
        self.image = word_font.render(f"{option}", True,
                                          '#f93a5a').convert_alpha()
        self.rect = self.image.get_rect(center=(posx, posy))
        self.direction = direction
    def move(self):
        if self.rect.x >= 1188:
            self.direction = "left"
        if self.direction == "left":
            self.rect.x -= 5
        if self.rect.x <= -110:
            self.direction = "right"
        if self.direction == "right":
            self.rect.x += 5
    def update(self):
        self.move()


def check_collisions(scores,game_active,prompt_word,options,ans):
    add_score = True
    if pygame.sprite.groupcollide(enemy, bullet, True, True):
        for e in enemy:
            if e.update() == ans:
                game_active = False
                add_score = False
        if add_score == True:
            scores += 1
            enemy.empty()
            bullet.empty()
            word.empty()
            prompt_word,options,ans = start_new_round()
            for a in range(0, 4):
                posx = choice([randint(100, 300), randint(500, 700), randint(900, 1160), randint(300, 700), randint(700, 1160)])
                posy = choice([randint(100, 300), randint(300, 500), randint(0, 500)])
                enemy.add(Enemy(posx, posy))
                word.add(Words(posx, posy, options[a], Enemy.get_direction(enemy.sprites()[a])))
                Enemy.assign_word(enemy.sprites()[a], options[a])
    return scores,game_active,prompt_word,options,ans

def get_score(scores):
    score_surface = score_font.render(f'Score: {scores}', True, 'black').convert_alpha()
    score_rect = score_surface.get_rect(center=(80,40))
    screen.blit(score_surface, score_rect)

def make_word_prompt():
    word_prompt_surface = prompt_font.render(f'Translation for {prompt_word}?',True,'#f93a5a').convert_alpha()
    word_prompt_rect = word_prompt_surface.get_rect(center=(620,80))
    screen.blit(word_prompt_surface,word_prompt_rect)

pygame.init()
clock = pygame.time.Clock()
screen_width = 1920
screen_height = 1080
game_active = True
scores = 0
screen = pygame.display.set_mode((screen_width,screen_height),pygame.FULLSCREEN)

ground_surface = pygame.image.load('graphics/Mossy Tileset/Mossy - FloatingPlatforms.png').convert_alpha()
ground_surface = pygame.transform.rotozoom(ground_surface,0,0.5)
ground_rect = ground_surface.get_rect(midbottom=(600,800))
sky_surface = pygame.image.load('graphics/Sky-1.png').convert_alpha()
sky_rect = sky_surface.get_rect(midbottom = (630,573))
score_font = pygame.font.Font('font/P22Underground-HvP (1).otf', 40)
prompt_font = pygame.font.Font('font/TerminusTTF-Bold.ttf',70)
word_font = pygame.font.Font('font/Pixeltype.ttf',80)

p = Player()
player = pygame.sprite.GroupSingle()
player.add(Player())
bullet = pygame.sprite.Group()
enemy = pygame.sprite.Group()
word = pygame.sprite.Group()
prompt_word,options,ans = start_new_round()
posx_and_posy = []
for a in range(0,4):
    posx = choice([randint(50,300)+randint(0,500),randint(550,774)+randint(0,500),randint(850,1160)+randint(0,500),randint(250,700)-randint(0,500),randint(750,1160)-randint(0,500)])
    posy = choice([randint(50,300)+randint(50,200),randint(350,500)-randint(50,200),randint(0,500)+randint(50,100)])
    enemy.add(Enemy(posx,posy))
    word.add(Words(posx,posy,options[a],Enemy.get_direction(enemy.sprites()[a])))
    Enemy.assign_word(enemy.sprites()[a],options[a])
userevent = pygame.USEREVENT + 1
pygame.time.set_timer(userevent, 2000)

while True:
    for event in pygame.event.get():
        if game_active:
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_q:
                    exit()
                    sys.exit()
        else:
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_SPACE:
                    game_active = True
                    player.sprite.rect.center = (600,501)
                    prompt_word,options,ans = start_new_round()
                    for a in range(0, 4):
                        posx = choice([randint(100, 300), randint(500, 700), randint(900, 1160), randint(300, 700),randint(700, 1160)])
                        posy = choice([randint(100, 300), randint(300, 500), randint(0, 500)])
                        enemy.add(Enemy(posx, posy))
                        word.add(Words(posx, posy, options[a], Enemy.get_direction(enemy.sprites()[a])))
                        Enemy.assign_word(enemy.sprites()[a], options[a])
                scores = 0

    if game_active:
        screen.fill('#d0f4f7')#'#ABD7EB'
        screen.blit(ground_surface,ground_rect)
        screen.blit(sky_surface,sky_rect)
        player.draw(screen)
        player.update()
        enemy.draw(screen)
        enemy.update()
        bullet.draw(screen)
        bullet.update()
        word.draw(screen)
        word.update()
        scores,game_active,prompt_word,options,ans = check_collisions(scores,game_active,prompt_word,options,ans)
        get_score(scores)
        make_word_prompt()
    else:
        screen.fill('black')
        enemy.empty()
        bullet.empty()
        word.empty()
        game_end_score = prompt_font.render(f'Score : {scores}',70,'white')
        game_end_score_rect = game_end_score.get_rect(center=(400, 70))
        screen.blit(game_end_score, game_end_score_rect)
    pygame.display.update()
    clock.tick(60)
