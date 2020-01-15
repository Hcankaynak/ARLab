using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementController : MonoBehaviour
{
    public GameObject achievements;
    public Sprite unDone;
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
        int temp = achievements.transform.childCount;

        for(int i = 0; i < temp; i++)
        {
            achievements.transform.GetChild(i).GetComponent<Image>().sprite = unDone;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.HasKey("flask"))
        {
            achievements.transform.GetChild(0).GetComponent<Image>().sprite = flask;

        }
        else if (PlayerPrefs.HasKey("base"))
        {
            achievements.transform.GetChild(1).GetComponent<Image>().sprite = bas;
        }
        else if (PlayerPrefs.HasKey("syringe"))
        {
            achievements.transform.GetChild(2).GetComponent<Image>().sprite = syringe;
        }
        else if (PlayerPrefs.HasKey("level1"))
        {
            achievements.transform.GetChild(3).GetComponent<Image>().sprite = level1;
        }
        else if (PlayerPrefs.HasKey("level2"))
        {
            achievements.transform.GetChild(4).GetComponent<Image>().sprite = level2;
        }
        else if (PlayerPrefs.HasKey("level5"))
        {
            achievements.transform.GetChild(5).GetComponent<Image>().sprite = level5;
        }
        else if (PlayerPrefs.HasKey("level10"))
        {
            achievements.transform.GetChild(6).GetComponent<Image>().sprite = level10;
        }
        else if (PlayerPrefs.HasKey("NH3"))
        {
            achievements.transform.GetChild(7).GetComponent<Image>().sprite = NH3;
        }
        else if (PlayerPrefs.HasKey("CO2"))
        {
            achievements.transform.GetChild(8).GetComponent<Image>().sprite = CO2;
        }
        else if (PlayerPrefs.HasKey("CH4"))
        {
            achievements.transform.GetChild(9).GetComponent<Image>().sprite = CH4;
        }
        else if (PlayerPrefs.HasKey("CCl4"))
        {
            achievements.transform.GetChild(10).GetComponent<Image>().sprite = CCl4;
        }
        else if (PlayerPrefs.HasKey("NCl3"))
        {
            achievements.transform.GetChild(11).GetComponent<Image>().sprite = NCl4;
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
