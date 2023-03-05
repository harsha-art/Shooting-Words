from random import choice,shuffle
hindi_words_and_prompts ={
    'No': ['nahi', 'apne', 'hota', 'diya'],
    'Year':['varsh','maheena','divas','saptaah'],
    'Hand':['haath','taang','ungaliya','shareer'],
    'Middle':['beech','baen','daeen','sahee'],
    'Person':['vyakti','jaanavar','machhalee','sher'],
    'Three':['teen','ek','das','sau'],
    'Elder':['bade','chhota','bachcha','aadamee'],
    'Grapes':['angoor','aam','kela','seb'],
    'What':['kya','kahaan','kab','kisaka'],
    'But':['lekin','aur','ka','par'],
    'Nearby':['paas','door','jagah','jaana'],
    'Fast':['tez','dheema','aana','jaana'],
    'Went':['gayii','jaana','aana','saptaah'],
    'India':['bharat','bhootaan','baanglaadesh','myaammaar'],
    'Run':['daudana','tahalana','tairana','bolana'],
    'Festival':['tyohaar','din','unka','bari'],
    'Vehicle':['vaahan','kitaab','mej','billee'],
    'Many':['bahut','kam','kuch','apne'],
    'Woman':['mahila','aadamee','aurat','purushon'],
    'People':['log','aadamee','bachche','purushon'],
}

hindi_words_and_Voices = {
    'No':'audio/Voice_Lines/Hindi_Audio_No.wav',
    'Year':'audio/Voice_Lines/Hindi_Audio_Year.wav',
    'Hand':'audio/Voice_Lines/Hindi_Audio_Hand.wav',
    'Middle':'audio/Voice_Lines/Hindi_Audio_Middle.wav',
    'Person':'audio/Voice_Lines/Hindi_Audio_Person.wav',
    'Three':'audio/Voice_Lines/Hindi_Audio_Three.wav',
    'Elder':'audio/Voice_Lines/Hindi_Audio_Elder.wav',
    'Grapes':'audio/Voice_Lines/Hindi_Audio_Grapes.wav',
    'What':'audio/Voice_Lines/Hindi_Audio_What.wav',
    'But':'audio/Voice_Lines/Hindi_Audio_But.wav',
    'Nearby':'audio/Voice_Lines/Hindi_Audio_Nearby.wav',
    'Fast':'audio/Voice_Lines/Hindi_Audio_Fast.wav',
    'Went':'audio/Voice_Lines/Hindi_Audio_Went.wav',
    'India':'audio/Voice_Lines/Hindi_Audio_India.wav',
    'Run':'audio/Voice_Lines/Hindi_Audio_Run.wav',
    'Festival':'audio/Voice_Lines/Hindi_Audio_Festival.wav',
    'Vehicle':'audio/Voice_Lines/Hindi_Audio_Vehicle.wav',
    'Many':'audio/Voice_Lines/Hindi_Audio_Many.wav',
    'Woman':'audio/Voice_Lines/Hindi_Audio_Mahila.wav',
    'People':'audio/Voice_Lines/Hindi_Audio_People.wav',
}

prompt_word = choice(list(hindi_words_and_prompts.keys()))
print(list(hindi_words_and_prompts.keys()))
options = hindi_words_and_prompts[prompt_word]
ans = hindi_words_and_prompts[prompt_word][0]
prompt_word_audio_file = hindi_words_and_Voices[prompt_word]

def start_new_round():
    list_of_words = list(hindi_words_and_prompts.keys())
    shuffle(list_of_words)
    prompt_word = choice(list_of_words)
    options = hindi_words_and_prompts[prompt_word]
    ans = hindi_words_and_prompts[prompt_word][0]
    prompt_word_audio_file = hindi_words_and_Voices[prompt_word]
    return prompt_word,options,ans,prompt_word_audio_file
