using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
      public int playerscore=0;
      public Text textscore2;
      
    public Text textscore;
    

    
     void Update(){
        
        textscore.text=playerscore.ToString();
        textscore2.text=textscore.text;
      
        
    }
}
