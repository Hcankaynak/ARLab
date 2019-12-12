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
            CollisionDispenser dispenser = collision.gameObject.GetComponent("CollisionDispenser") as CollisionDispenser;
            Debug.Log(dispenser.pH);
            if (dispenser.pH == 1)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (dispenser.pH == 2)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            

        }
        else if(collision.gameObject.tag == "Tube")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (collision.gameObject.tag == "Base")
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
            CollisionDispenser dispenser = collision.gameObject.GetComponent("CollisionDispenser") as CollisionDispenser;
            if (dispenser.pH == 1)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (dispenser.pH == 2)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }

        }
    }


}
