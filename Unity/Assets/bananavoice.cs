using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananavoice : MonoBehaviour
{
    public AudioSource banana;
    // Start is called before the first frame update
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
