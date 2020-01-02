using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementController : MonoBehaviour
{
    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    public GameObject test5;
    public GameObject test6;
    public GameObject test7;

    public Sprite done;
    public Sprite notDone;


    // Start is called before the first frame update
    void Start()
    {
        test1.GetComponent<Image>().sprite = notDone;
        
        test1.GetComponent<Image>().sprite = notDone;
        test2.GetComponent<Image>().sprite = notDone;
        test3.GetComponent<Image>().sprite = notDone;
        test4.GetComponent<Image>().sprite = notDone;
        test5.GetComponent<Image>().sprite = notDone;
        test6.GetComponent<Image>().sprite = notDone;
        test7.GetComponent<Image>().sprite = notDone;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.HasKey("test1"))
        {
            test1.GetComponent<Image>().sprite = done;

        }
        else
        {
            test1.GetComponent<Image>().sprite = notDone;
        }

        if (PlayerPrefs.HasKey("test2"))
        {
            test2.GetComponent<Image>().sprite = done;

        }
        else
        {
            test2.GetComponent<Image>().sprite = notDone;
        }
        if (PlayerPrefs.HasKey("test3"))
        {
            test3.GetComponent<Image>().sprite = done;

        }
        else
        {
            test3.GetComponent<Image>().sprite = notDone;
        }
        if (PlayerPrefs.HasKey("test4"))
        {
            test4.GetComponent<Image>().sprite = done;

        }
        else
        {
            test4.GetComponent<Image>().sprite = notDone;
        }
        if (PlayerPrefs.HasKey("test5"))
        {
            test5.GetComponent<Image>().sprite = done;

        }
        else
        {
            test5.GetComponent<Image>().sprite = notDone;
        }
        if (PlayerPrefs.HasKey("test6"))
        {
            test6.GetComponent<Image>().sprite = done;

        }
        else
        {
            test6.GetComponent<Image>().sprite = notDone;
        }
        if (PlayerPrefs.HasKey("test7"))
        {
            test7.GetComponent<Image>().sprite = done;

        }
        else
        {
            test7.GetComponent<Image>().sprite = notDone;
        }

    }
    public void ChangeImage()
    {
        Debug.Log("bla");

        PlayerPrefs.SetInt("test1", 1);
        PlayerPrefs.SetInt("test3", 1);
        

    }
    public void ress()
    {
        PlayerPrefs.DeleteAll();
    }
    
    
        
    


}
