using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerper : MonoBehaviour
{

    public float speed = 0.01f;
    public Color newColor;
    public bool active = false;
    public bool activation = false;
    float startTime;

    // Update is called once per frame
    void Update()
    {
        if (activation)
        {
            active = true;
            activation = false;
            startTime = Time.time;
        }
        if (active)
        {
            float t = (Time.time - startTime) * speed;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(gameObject.GetComponent<MeshRenderer>().material.color, newColor, t);
            if (gameObject.GetComponent<MeshRenderer>().material.color == newColor)
            {
                active = false;
            }
        }
    }

}
