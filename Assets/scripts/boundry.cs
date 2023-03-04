using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundry : MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectHeight;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y ;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewpos = transform.position;
        viewpos.y = Mathf.Clamp(viewpos.y,screenBounds.y + objectHeight,screenBounds.y * -1 - objectHeight);
        transform.position = viewpos;
    }
}
