using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class invi : MonoBehaviour
{
    
    public GameObject gameover;
    public GameObject load_screen;
    public target_gen tar_object;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        tar_object=GameObject.FindGameObjectWithTag("ftarget").GetComponent<target_gen>();
        
        Time.timeScale=0;
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1;
    }
    public void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag=="Collisiontag"&&tar_object.randomValue=="banana"){
            gameover.SetActive(true);
            Time.timeScale=0;
            
            
        }
        if(collision.gameObject.tag=="collisionGrape"&&tar_object.randomValue=="grape"){
            gameover.SetActive(true);
            Time.timeScale=0;
           
        }
        if(collision.gameObject.tag=="CollisionLemon"&&tar_object.randomValue=="lemon"){
            gameover.SetActive(true);
            Time.timeScale=0;
           
        }
        

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)){
            load_screen.SetActive(false);
            Time.timeScale=1;
         }
        
    }
}
