using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitHydrogen : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject electron;

    float speed = 150;
    Vector3 foo;
    Vector3 pos;

    private void Start()
    {
        electron = Instantiate(electron, transform.position + new Vector3(0, 0.1f, 0), transform.rotation);
        
        pos = electron.transform.position - transform.position;
        foo = transform.position;


    }
    private void Update()
    {

        if (foo != transform.position)
        {
            electron.transform.position = transform.position + pos;
            
            foo = transform.position;
        }

        orbitAround();
    }
    void orbitAround()
    {

        electron.transform.RotateAround(transform.position, Vector3.right, speed * Time.deltaTime);
        

    }
}
