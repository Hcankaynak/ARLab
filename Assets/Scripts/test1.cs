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

       
        GameObject go = Instantiate(gam, new Vector3(0, 0.05f, 0), gam.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        




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
    
}
