using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLevel1() {PlayerPrefs.SetInt("CurrentLevel", 1);}

    public void setLevel2() {PlayerPrefs.SetInt("CurrentLevel", 2);}

    public void setLevel3() { PlayerPrefs.SetInt("CurrentLevel", 3); }

    public void setLevel4() { PlayerPrefs.SetInt("CurrentLevel", 4); }

    public void setLevel5() { PlayerPrefs.SetInt("CurrentLevel", 5); }

    public void setLevel6() { PlayerPrefs.SetInt("CurrentLevel", 6); }
}
