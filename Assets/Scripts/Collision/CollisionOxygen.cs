using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOxygen : MonoBehaviour
{
    // Start is called before the first frame update
    public bool connection1;
    public bool connection2;
    private LineRenderer line1;

    GameObject gam1;
    GameObject gam2;
    private int col;


    private void Start()
    {
        connection1 = true;
        connection2 = true;
        gam1 = null;
        gam2 = null;
        // Add a Line Renderer to the GameObject
        


    }
    private void Update()
    {
        if (gam1)
        {
            line1.SetPosition(0, transform.position);
            line1.SetPosition(1, gam1.transform.position);
        }
        if(gam2){

            line1.SetPosition(2, transform.position);
            line1.SetPosition(3, gam2.transform.position);

        }

       
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(col != collision.gameObject.GetInstanceID())
        {

            col = collision.gameObject.GetInstanceID();
            if (collision.gameObject.tag == "Hydrogen")
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
                    line1 = gameObject.AddComponent<LineRenderer>();
                    // Set the width of the Line Renderer
                    line1.SetWidth(0.05F, 0.05F);
                    // Set the number of vertex fo the Line Renderer
                    line1.positionCount = 2;
                    line1.material.color = Color.black;
                    line1.SetPosition(0, transform.position);
                    line1.SetPosition(1, collision.gameObject.transform.position);
                    gam1 = collision.gameObject;


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
                    // Set the width of the Line Renderer
                    // Set the number of vertex fo the Line Renderer
                    line1.positionCount = 4;

                    line1.SetPosition(2,transform.position);
                    line1.SetPosition(3, collision.gameObject.transform.position);

                    gam2 = collision.gameObject;

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
                    line1 = gameObject.AddComponent<LineRenderer>();
                    // Set the width of the Line Renderer

                    line1.SetWidth(0.05F, 0.05F);
                    // Set the number of vertex fo the Line Renderer
                    line1.SetVertexCount(2);
                    line1.material.color = Color.black;
                    line1.SetPosition(0, transform.position);
                    line1.SetPosition(1, collision.gameObject.transform.position);
                    gam1 = collision.gameObject;


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
                    line1.positionCount = 4;
                    line1.SetPosition(2, transform.position);
                    line1.SetPosition(3, collision.gameObject.transform.position);
                    gam2 = collision.gameObject;

                }

            }
        }

       

    }
    
}
