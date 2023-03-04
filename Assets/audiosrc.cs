using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosrc : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clp1,clp2,clp3;
    public int num=0;
    void start()
    {
        
    }
    public void soundtrack()
    {
        src = GetComponent<AudioSource>();
        switch (num)
        {
            case 0: src.clip = clp1;
                    src.Play();
                    num++;
                    break;
            case 1: src.clip = clp2;
                    src.Play();
                    num++;
                    break;
            case 2: src.clip = clp3;
                    src.Play();
                    num++;
                    break;
            default:   num=0;
                       src.clip = clp1;
                       src.Play();
                       num++;
                       break; 
        }
    }

}
