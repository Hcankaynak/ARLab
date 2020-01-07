using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCarbon : MonoBehaviour
{
    // Start is called before the first frame update
    public bool connection1;
    public bool connection2;
    public bool connection3;
    public bool connection4;
    private LineRenderer line1;
    private LineRenderer line2;
    private LineRenderer line3;
    private LineRenderer line4;
    GameObject gam1;
    GameObject gam2;
    GameObject gam3;
    GameObject gam4;

    private void Start()
    {

        connection1 = true;
        connection2 = true;
        connection3 = true;
        connection4 = true;
        gam1 = null;
        gam2 = null;
        gam3 = null;
        gam4 = null;



    }
    private void Update()
    {
        if (gam1)
        {
            line1.SetPosition(0, transform.position);
            line1.SetPosition(1, gam1.transform.position);
        }
        else if (gam2)
        {

            line2.SetPosition(0, transform.position);
            line2.SetPosition(1, gam2.transform.position);
            
        }
        else if (gam3)
        {
            line3.SetPosition(0, transform.position);
            line3.SetPosition(1, gam3.transform.position);
        }
        else if (gam4)
        {
            line4.SetPosition(0, transform.position);
            line4.SetPosition(1, gam4.transform.position);
        }



    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Hydrogen")
        {

            if (connection1)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(2, 0, 0);
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
                fixedJoint.anchor = new Vector3(-2, 0, 0);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection2 = false;
                line2 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line2.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line2.SetVertexCount(2);
                line2.material.color = Color.black;
                line2.SetPosition(0, transform.position);
                line2.SetPosition(1, collision.gameObject.transform.position);
                gam2 = collision.gameObject;

            }
            else if (connection3)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(0, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection3 = false;
                line3 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line3.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line3.SetVertexCount(2);
                line3.material.color = Color.black;
                line3.SetPosition(0, transform.position);
                line3.SetPosition(1, collision.gameObject.transform.position);
                gam3 = collision.gameObject;
            }
            else if (connection4)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(0, 0, -2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection4 = false;
                line4 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line4.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line4.SetVertexCount(2);
                line4.material.color = Color.black;
                line4.SetPosition(0, transform.position);
                line4.SetPosition(1, collision.gameObject.transform.position);
                gam4 = collision.gameObject;
            }


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
                line2 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line2.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line2.SetVertexCount(2);
                line2.material.color = Color.black;
                line2.SetPosition(0, transform.position);
                line2.SetPosition(1, collision.gameObject.transform.position);
                gam2 = collision.gameObject;

            }
            else if (connection3)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(0, 0, 2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection3 = false;
                line3 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line3.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line3.SetVertexCount(2);
                line3.material.color = Color.black;
                line3.SetPosition(0, transform.position);
                line3.SetPosition(1, collision.gameObject.transform.position);
                gam3 = collision.gameObject;
            }
            else if (connection4)
            {
                FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
                fixedJoint.autoConfigureConnectedAnchor = false;
                fixedJoint.anchor = new Vector3(0, 0, -2);
                fixedJoint.connectedAnchor = Vector3.zero;
                gameObject.GetComponent<Rigidbody>().freezeRotation = true;
                connection4 = false;
                line4 = gameObject.AddComponent<LineRenderer>();
                // Set the width of the Line Renderer
                line4.SetWidth(0.05F, 0.05F);
                // Set the number of vertex fo the Line Renderer
                line4.SetVertexCount(2);
                line4.material.color = Color.black;
                line4.SetPosition(0, transform.position);
                line4.SetPosition(1, collision.gameObject.transform.position);
                gam4 = collision.gameObject;
            }
        }



    }

}
