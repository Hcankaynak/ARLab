using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeAchievement : MonoBehaviour
{

    public GameObject achievement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (PlayerPrefs.HasKey("test5"))
            {
                achievement.SetActive(true);
                StartCoroutine(HandleIt());
                achievement.SetActive(false);
                PlayerPrefs.SetInt("test5-1", 1);

            }
            else
            {
                achievement.SetActive(false);
            }
        
        
    }

    private IEnumerator HandleIt()
    {
        
        // process pre-yield
        yield return new WaitForSeconds(1.0f);
        // process post-yield

    }

    
}
