using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject first;
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene("First");
        
    }
    public void playGame2()
    {
        SceneManager.LoadScene("Second");
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void returnMain()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("achi"))
        {
            first.SetActive(false);
        }
    }

}
