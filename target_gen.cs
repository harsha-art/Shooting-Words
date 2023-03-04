using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target_gen : MonoBehaviour
{
    public Text rand_target;
    public float timeBetweenRandomValueAssignments = 1000f;
    public string[] possibleValues=new string[]{"banana","lemon","grape"};

    public string randomValue;
    private float timer;

    void Start()
    {
        
        randomValue = possibleValues[Random.Range(0, possibleValues.Length)];
        rand_target.text=randomValue.ToString();
    }

    void Update()
    {
        // increment the timer by the amount of time since the last frame
        timer += Time.deltaTime;

        
        if (timer >= timeBetweenRandomValueAssignments)
        {
            randomValue = possibleValues[Random.Range(0, possibleValues.Length)];
            rand_target.text=randomValue.ToString();
            timer = 0f; // reset the timer
        }

        
      
    }

}
