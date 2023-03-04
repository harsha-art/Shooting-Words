using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meterospawnscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject metero;
    public float Spawner=6;
    private float timer =0;
    public float heightOffset = 4;
    void Start()
    {
        spawnmetero();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < Spawner)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnmetero();
            timer=0;
        }
    }
    private void spawnmetero()
    {
        float lower = transform.position.y - heightOffset;
        float higher = transform.position.y + heightOffset;
        Instantiate(metero, new Vector3(transform.position.x ,Random.Range( lower,higher),0),transform.rotation);
    }
    
}
