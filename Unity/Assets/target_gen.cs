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
        if(randomValue=="banana"){
            rand_target.text="Banana";

        }
        if(randomValue=="grape"){
            rand_target.text="Grape";

        }
        if(randomValue=="Lemon"){
            rand_target.text="Lemon";

        }
    }

    void Update()
    {
        // increment the timer by the amount of time since the last frame
        timer += Time.deltaTime;

        
        if (timer >= timeBetweenRandomValueAssignments)
        {
            randomValue = possibleValues[Random.Range(0, possibleValues.Length)];
           
             if(randomValue=="banana"){
            rand_target.text="Banana";

        }
        if(randomValue=="grape"){
            rand_target.text="Grape";

        }
        if(randomValue=="Lemon"){
            rand_target.text="Lemon";

        }
            timer = 0f; // reset the timer
        }

        
      
    }

}
