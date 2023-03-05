using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicscrpt : MonoBehaviour
{
    public int playerscore=0;
    public Text textscore;
    public int highScore=0;

    
     void Update(){
        
        textscore.text=playerscore.ToString();
        
        
    }
    // Start is called before the first frame update
   
}
