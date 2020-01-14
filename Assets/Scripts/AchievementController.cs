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
    public GameObject test8;
    public GameObject test9;
    public GameObject test10;

    

    public Sprite flask;
    public Sprite bas;
    public Sprite syringe;
    public Sprite level1;
    public Sprite level2;
    public Sprite level5;
    public Sprite level10;
    public Sprite NH3;
    public Sprite CO2;
    public Sprite CH4;
    public Sprite CCl4;
    public Sprite NCl4;




    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.HasKey("test1"))
        {
            test1.GetComponent<Image>().sprite = flask;

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
