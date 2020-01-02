using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{

    public GameObject gam;
    public GameObject tel;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("test1", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        PlayerPrefs.SetInt("test5", 1);
    }
    public void lossy()
    {
        Debug.Log("lossy:" + gam.transform.lossyScale);
        Debug.Log("flask collider:" + gam.GetComponent<Collider>().bounds.size);
        Debug.Log("flask renderer:" + gam.GetComponent<Renderer>().bounds.size);

        Debug.Log("dispenser collider:" + tel.GetComponent<Collider>().bounds.size);
        Debug.Log("dispenser collider:" + tel.GetComponent<Renderer>().bounds.size);



    }
}
