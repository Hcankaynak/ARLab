using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{

    public GameObject gam;
    float startTime;
    float speed = 1f;
    float journey;
    float journeyDis;
    Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        v = gam.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        float dist = (Time.time - startTime) * speed;
        journey = dist / 1;
        //gameObject.GetComponent<Renderer>().material.color = Color.red;
        Color.Lerp(gam.GetComponent<Renderer>().material.color, Color.red, Time.time);

        

        
        
    }

    public void test()
    {

    }
    public void lossy()
    {
        Debug.Log("lossy:" + gam.transform.lossyScale);
        Debug.Log("flask collider:" + gam.GetComponent<Collider>().bounds.size);
        Debug.Log("flask renderer:" + gam.GetComponent<Renderer>().bounds.size);

        


    }
    public void complete()
    {
        PlayerPrefs.SetInt("achi", 1);
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if(collision.gameObject.tag == "Tube")
        {
            v = gam.transform.position;
            Debug.Log("Lerp: " + ( Vector3.Lerp(v, v + new Vector3(0, 1, 0), Time.time / 3)));
            gam.transform.position = Vector3.Lerp(v, v + new Vector3(0, 1, 0), Time.time / 3);
        }
        
    }
}
