using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOxygen : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject electron;
    public GameObject electron1;
    public GameObject electron2;
    public GameObject electron3;
    public GameObject electron4;
    public GameObject electron5;
    public float speed;
    Vector3 foo;
    Vector3 pos;

    private void Start()
    {
        pos = electron.transform.position - transform.position;
        foo = transform.position;
    }
    private void Update()
    {
        
        if ( foo != transform.position)
        {
            electron.transform.position = transform.position + pos ;
            electron1.transform.position = transform.position + pos;
            electron2.transform.position = transform.position + pos;
            electron3.transform.position = transform.position + pos;
            electron4.transform.position = transform.position + pos;
            electron5.transform.position = transform.position + pos;
            foo = transform.position;
        }
        
        orbitAround();
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Element")
        {
            FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
            fixedJoint.autoConfigureConnectedAnchor = false;
            fixedJoint.anchor = new Vector3(1, 1, 1);
            fixedJoint.connectedAnchor = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
        }
    }
    void orbitAround()
    {

        
        electron.transform.RotateAround(transform.position, Vector3.right, speed * Time.deltaTime);
        electron1.transform.RotateAround(transform.position, Vector3.left, speed * Time.deltaTime);
        electron2.transform.RotateAround(transform.position, Vector3.forward, speed * Time.deltaTime);
        electron3.transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);
        electron4.transform.RotateAround(transform.position, new Vector3(-1,0,-1), speed * Time.deltaTime);
        electron5.transform.RotateAround(transform.position, new Vector3(1, 0, 1), speed * Time.deltaTime);

    }
}
