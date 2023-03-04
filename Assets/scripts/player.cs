using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform bulletsp;
    public GameObject bulletprefab;
    public float bspeed =10;
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4)
        {
            transform.position = new Vector2(transform.position.x,4);
        }
        if(transform.position.y <= -4)
        {
            transform.position = new Vector2(transform.position.x,-4);
        }
        if(Input.GetKeyDown(KeyCode.Space)==true)
        {
        var bullet = Instantiate(bulletprefab,bulletsp.position,bulletsp.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletsp.right * bspeed;
        }
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.y += v * Time.deltaTime * speed;

        transform.position = pos;
    }
}
