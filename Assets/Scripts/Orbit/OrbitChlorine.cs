using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitChlorine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject electron;
    public GameObject electron1;
    public GameObject electron2;
    public GameObject electron3;
    public GameObject electron4;
    public GameObject electron5;
    public GameObject electron6;
    float speed = 150;
    Vector3 foo;
    Vector3 pos;

    private void Start()
    {
        electron = Instantiate(electron, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron1 = Instantiate(electron1, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron2 = Instantiate(electron2, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron3 = Instantiate(electron3, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron4 = Instantiate(electron4, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron5 = Instantiate(electron5, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        electron6 = Instantiate(electron6, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);

        pos = electron.transform.position - transform.position;
        foo = transform.position;


    }
    private void Update()
    {

        if (foo != transform.position)
        {
            electron.transform.position = transform.position + pos;
            electron1.transform.position = transform.position + pos;
            electron2.transform.position = transform.position + pos;
            electron3.transform.position = transform.position + pos;
            electron4.transform.position = transform.position + pos;
            electron5.transform.position = transform.position + pos;
            electron6.transform.position = transform.position + pos;
            foo = transform.position;
        }

        orbitAround();
    }
    void orbitAround()
    {


        electron.transform.RotateAround(transform.position, Vector3.right, speed * Time.deltaTime);
        electron1.transform.RotateAround(transform.position, Vector3.left, speed * Time.deltaTime);
        electron2.transform.RotateAround(transform.position, Vector3.forward, speed * Time.deltaTime);
        electron3.transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);
        electron4.transform.RotateAround(transform.position, new Vector3(-1, 0, -1), speed * Time.deltaTime);
        electron5.transform.RotateAround(transform.position, new Vector3(1, 0, 1), speed * Time.deltaTime);
        electron6.transform.RotateAround(transform.position, new Vector3(1, 0, -1), speed * Time.deltaTime);


    }
}
