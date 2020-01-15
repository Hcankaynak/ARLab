using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public GameObject levels;
    public GameObject levels2;
    // Start is called before the first frame update

    void Start()
    {
        if (!PlayerPrefs.HasKey("LevelManager"))
        {
            PlayerPrefs.SetInt("LevelManager", 1);
        }
        if (!PlayerPrefs.HasKey("LevelManager2"))
        {
            PlayerPrefs.SetInt("LevelManager2",1);
        }
        int temp = levels.transform.childCount;
        for (int i = 0; i < temp; i++)
        {
            levels.transform.GetChild(i).GetComponent<Button>().interactable = false;
        }
        int temp2 = levels2.transform.childCount;
        for (int i = 0; i < temp2; i++)
        {
            levels2.transform.GetChild(i).GetComponent<Button>().interactable = false;
        }


    }


    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("LevelManager"));
        int temp = PlayerPrefs.GetInt("LevelManager");
        for(int i = 0;i< temp; i++)
        {
            levels.transform.GetChild(i).GetComponent<Button>().interactable = true;
        }
        Debug.Log(PlayerPrefs.GetInt("LevelManager2"));
        int temp2 = PlayerPrefs.GetInt("LevelManager2");
        for (int i = 0; i < temp2; i++)
        {
            levels2.transform.GetChild(i).GetComponent<Button>().interactable = true;
        }

    }

    public void setLevel0() { PlayerPrefs.SetInt("CurrentLevel", 0); }

    public void setLevel1() {PlayerPrefs.SetInt("CurrentLevel", 1);}

    public void setLevel2() {PlayerPrefs.SetInt("CurrentLevel", 2);}

    public void setLevel3() { PlayerPrefs.SetInt("CurrentLevel", 3); }

    public void setLevel4() { PlayerPrefs.SetInt("CurrentLevel", 4); }

    public void setLevel5() { PlayerPrefs.SetInt("CurrentLevel", 5); }

    public void setLevel6() { PlayerPrefs.SetInt("CurrentLevel", 6); }

    public void set2Level0() { PlayerPrefs.SetInt("CurrentLevel2", 0); }
    public void set2Level1() { PlayerPrefs.SetInt("CurrentLevel2", 1); }
    public void set2Level2() { PlayerPrefs.SetInt("CurrentLevel2", 2); }
    public void set2Level3() { PlayerPrefs.SetInt("CurrentLevel2", 3); }
    public void set2Level4() { PlayerPrefs.SetInt("CurrentLevel2", 4); }
    public void set2Level5() { PlayerPrefs.SetInt("CurrentLevel2", 5); }
    public void set2Level6() { PlayerPrefs.SetInt("CurrentLevel2", 6); }
}
