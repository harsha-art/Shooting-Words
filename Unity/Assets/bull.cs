using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bull : MonoBehaviour
{
    
    
    public LogicScript logici;
    public target_gen tar_object;
    public AudioSource audios;
    public AudioSource audios2;
    public AudioSource audios3;
    
    void start(){

        
        
    } 
    


    public void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag=="Collisiontag"){
            audios.Play();
            
           
            
          if(tar_object.randomValue=="banana")
           logici.playerscore+=1;
          
            
            
        }
        if(collision.gameObject.tag=="collisionGrape"){
            audios2.Play();
           
            
           
            
            
            
            
            if(tar_object.randomValue=="grape")
             logici.playerscore+=1;
             
           ;  
        }
        if(collision.gameObject.tag=="CollisionLemon"){
            audios3.Play();
           
           
            if(tar_object.randomValue=="lemon")
             logici.playerscore+=1;
             

            
        }
      
    }
    public Rigidbody2D myrigidbod;
    // Start is called before the first frame update
    public float life = 3;
    
    void Awake()
    {
        logici=GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        tar_object=GameObject.FindGameObjectWithTag("ftarget").GetComponent<target_gen>();
        myrigidbod.velocity=Vector2.right*100;
        
        
        Destroy(gameObject, life);
    }
}
