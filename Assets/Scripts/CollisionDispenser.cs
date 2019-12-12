using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDispenser : MonoBehaviour
{
    public int pH = 1;
    
    // Start is called before the first frame update
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mehmet was here");

        if (collision.gameObject.tag == "Tube")
        {

            pH = 1;

        }
        else if(collision.gameObject.tag == "Base")
        {
            pH = 2;
        }
    }
    void OnCollisionStay(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mahmut was here");
        if (collision.gameObject.tag == "Tube")
        {
            pH = 1;

        }
        else if (collision.gameObject.tag == "Base")
        {
            pH = 2;
        }
    }

}
