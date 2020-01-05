using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOxygen : MonoBehaviour
{
    // Start is called before the first frame update
    public bool connection1;
    public bool connection2;


    private void Start()
    {
        connection1 = true;
        connection2 = true;

        
    }
    private void Update()
    {


       
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Hydrogen")
        {
            
            if (connection1 )
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection1 = false;
                

            }
            else if (connection2)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(-2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection2 = false;
                
            }
            else
            {
                //collision.rigidbody.AddForce(new Vector3(0.1f, 0, 0));
            }
            Debug.Log(connection1);
            Debug.Log(connection2);
        }
        else if (collision.gameObject.tag == "Chlorine")
        {
            if (connection1)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection1 = false;


            }
            else if (connection2)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(-2, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection2 = false;

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
