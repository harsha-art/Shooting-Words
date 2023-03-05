using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leg : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
   
    // Start is called before the first frame update
   public float bulletforce=20f;
void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
           
        Shoot();
         
        }  
    
    }
    // Update is called once per frame
    public void Shoot()
    {
            
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        myrigidbody.AddForce(bulletSpawnPoint.forward*bulletforce,ForceMode2D.Impulse);

        
    }
}}
