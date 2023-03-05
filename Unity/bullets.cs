using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    // Start is called before the first frame update
    public float life = 3;
 
    void Awake()
    {
        Destroy(gameObject, life);
    }
}
