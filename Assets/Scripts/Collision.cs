using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{



    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mehmet was here");
        if (collision.gameObject.tag == "dispenser")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }
    }
    void OnCollisionStay(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mahmut was here");
        if (collision.gameObject.tag == "dispenser")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }
    }

}
