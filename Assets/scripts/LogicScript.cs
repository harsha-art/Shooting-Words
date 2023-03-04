using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text name;
    public int number=0;
    [ContextMenu("name")]
    public void assign()
    {
        var list = new List<string>();
        list.Add("Apple");
        list.Add("Mother");
        list.Add("Brother");
        var list1 = new List<string>();
        list1.Add("Apfel");
        list1.Add("Mutter");
        list1.Add("Bruder");
        if(number<3)
        {
            name.text = list[number].ToString() + " = " +list1[number].ToString();
            
            number++;
        }
        else
        {
            number=0;
            name.text = list[number].ToString() + " = " +list1[number].ToString();
            number++;
        }
    }
}
