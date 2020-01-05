using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool OxyCon1;
    public bool OxyCon2;


    private void Start()
    {
        OxyCon1 = true;
        OxyCon2 = true;


    }
    private void Update()
    {



    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        
        if (collision.gameObject.tag == "Azote")
        {

            if (OxyCon1)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                OxyCon1 = false;


            }
            else if (OxyCon2)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(-2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                OxyCon2 = false;

            }
            else
            {
               
            }
            Debug.Log(OxyCon1);
            Debug.Log(OxyCon2);
        }
        else if(collision.gameObject.tag == "Chlorine"){
            if (OxyCon1)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                OxyCon1 = false;


            }
            else if (OxyCon2)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(-2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                OxyCon2 = false;

            }
            else
            {

            }
        }
        
       


    }
    void orbitAround()
    {


    }
}
