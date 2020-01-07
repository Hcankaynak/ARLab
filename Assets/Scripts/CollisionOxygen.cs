﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOxygen : MonoBehaviour
{
    // Start is called before the first frame update
    public bool connection1;
    public bool connection2;
    private LineRenderer line1;
    private LineRenderer line2;
    GameObject gam1;
    GameObject gam2;


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
        else if (gam2){

            line2.SetPosition(0, transform.position);
            line2.SetPosition(1, gam2.transform.position);
        }

       
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
                line2.SetPosition(0, transform.position);
                line2.SetPosition(1, collision.gameObject.transform.position);
                gam2 = collision.gameObject;

            }
            else
            {

            }
        }



    }
    
}