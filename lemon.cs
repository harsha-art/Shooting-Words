using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemon : MonoBehaviour
{
    // Start is called before the first frame update    public AudioSource banana;
    // Start is called before the first frame update
     public AudioSource banana;
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        banana.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
