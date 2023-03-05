using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grape_src : MonoBehaviour
{
    public GameObject effect;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        Instantiate(effect,transform.position,Quaternion.identity);}

    }
   

        

    

    // Update is called once per frame
   