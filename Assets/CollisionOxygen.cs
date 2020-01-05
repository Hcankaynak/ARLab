using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOxygen : MonoBehaviour
{
    // Start is called before the first frame update
    bool connection1;
    bool connection2;

    private void Start()
    {
        connection1 = false;
        connection2 = false;
    }
    private void Update()
    {


       
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Element")
        {
            if (connection1)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(1, 1, 1);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;

            }
            else if (connection2)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(1, 1, 1);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
    }
    void orbitAround()
    {

        
    }
}
