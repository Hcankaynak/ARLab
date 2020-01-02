using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
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
    
}
