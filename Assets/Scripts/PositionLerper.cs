using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLerper : MonoBehaviour
{

    public float speed = 0.1f;
    public Vector3 newPosition;
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
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, newPosition, t);
            if (Vector3.Distance(gameObject.transform.position, newPosition) < 0.001f)
            {
                active = false;
            }
        }
    }

}
