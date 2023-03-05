using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gok : MonoBehaviour
{
    
    public Rigidbody2D myrigidbody;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           
        myrigidbody.velocity=Vector2.up*10;
         
            
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        }
    }
}
