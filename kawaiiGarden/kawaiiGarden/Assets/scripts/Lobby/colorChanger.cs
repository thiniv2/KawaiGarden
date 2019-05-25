using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    public float speed = 1f;
    float startTime;
    public Color StartColor;
    public Color EndColor;
    
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

         //StartColor = Random.ColorHSV(1, 1, 1, 1);
         //EndColor = Random.ColorHSV(0, 0, 0, 0);

        float t = (Mathf.Sin(Time.time - startTime) * speed);

        GetComponent<Renderer>().material.color = Color.Lerp(StartColor, EndColor, t);
        
    }

}
