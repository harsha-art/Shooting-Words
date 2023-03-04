
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op1movescript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float dead= -45;
    public LogicScript logic;
    public audiosrc audio;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audio = GameObject.FindGameObjectWithTag("audio").GetComponent<audiosrc>();
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 move;
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < dead)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        audio.soundtrack();
        logic.assign();
    }
}
