using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class checkTrueSecond : MonoBehaviour
{
	
    public GameObject CorrectPanel;
    public GameObject FalsePanel;

	// Start is called before the first frame update
	void Start()
	{
		

	}

	// Update is called once per frame
	void Update()
	{
        Debug.Log("test" + PlayerPrefs.GetInt("CurrentLevel2"));
    }
	
    public void checkMolecules() {
        List<GameObject> rootObjects = new List<GameObject>();
        Scene scene = SceneManager.GetActiveScene();
        scene.GetRootGameObjects(rootObjects);
        string tryout = "";
        string tryout2 = "";
        string tryout3 = "";
        string tryout4 = "";
        bool final = false;
        if (PlayerPrefs.GetInt("CurrentLevel2") == 1)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Oxygen")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        if (tryout != "")
                        {
                            tryout2 = component.connectedBody.tag;
                        }
                        else
                        {
                            tryout = component.connectedBody.tag;
                        }
                    }
                    if (tryout == "Hydrogen" && tryout2 == "Hydrogen")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura h20 demek
                Debug.Log("H2O");
                PlayerPrefs.SetInt("CurrentLevel2", 2);
                PlayerPrefs.SetInt("LevelManager2", 2);
                CorrectPanel.SetActive(true);

                
            }
            else
            {
                Debug.Log(PlayerPrefs.GetInt("CurrentLevel2"));
                Debug.Log("Yok");
                
                FalsePanel.SetActive(true);
            }
            tryout = "";
            tryout2 = "";
            final = false;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel2") == 2)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Carbon")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        if (tryout != "")
                        {
                            if (tryout2 != "")
                            {
                                if (tryout3 != "")
                                {
                                    tryout4 = component.connectedBody.tag;
                                }
                                else
                                {
                                    tryout3 = component.connectedBody.tag;
                                }
                            }
                            else
                            {
                                tryout2 = component.connectedBody.tag;
                            }
                        }
                        else
                        {
                            tryout = component.connectedBody.tag;
                        }
                    }
                    if (tryout == "Hydrogen" && tryout2 == "Hydrogen" && tryout3 == "Hydrogen" && tryout4 == "Hydrogen")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura ch4 demek
                PlayerPrefs.SetInt("CH4", 4);
                PlayerPrefs.SetInt("LevelManager2", 3);
                PlayerPrefs.SetInt("CurrentLevel2", 3);
                CorrectPanel.SetActive(true);
                
            }
            else
            {
                //bura ch4 yok demek
                FalsePanel.SetActive(true);
            }
            tryout = "";
            tryout2 = "";
            tryout3 = "";
            tryout4 = "";
            final = false;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel2") == 3)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Chlorine")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        tryout = component.connectedBody.tag;

                    }
                    if (tryout == "Hydrogen")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura hcl demek
                PlayerPrefs.SetInt("level1", 4);
                PlayerPrefs.SetInt("CurrentLevel2", 4);
                PlayerPrefs.SetInt("LevelManager2", 4);
                CorrectPanel.SetActive(true);
                
            }
            else
            {
                //bura hcl yok demek
                FalsePanel.SetActive(true);
            }
            tryout = "";
            final = false;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel2") == 4)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Azote")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        if (tryout != "")
                        {
                            if (tryout2 != "")
                            {
                                tryout3 = component.connectedBody.tag;
                            }
                            else
                            {
                                tryout2 = component.connectedBody.tag;
                            }
                        }
                        else
                        {
                            tryout = component.connectedBody.tag;
                        }
                    }
                    if (tryout == "Hydrogen" && tryout2 == "Hydrogen" && tryout3 == "Hydrogen")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura nh3 demek
                PlayerPrefs.SetInt("NH3", 1);
                PlayerPrefs.SetInt("CurrentLevel2", 5);
                PlayerPrefs.SetInt("LevelManager2", 5);
                CorrectPanel.SetActive(true);
                
            }
            else
            {
                //bura nh3 yok demek

                FalsePanel.SetActive(true);
                Debug.Log(PlayerPrefs.GetInt("CurrentLevel2"));
            }
            tryout = "";
            tryout2 = "";
            tryout3 = "";
            final = false;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel2") == 5)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Carbon")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        if (tryout != "")
                        {
                            if (tryout2 != "")
                            {
                                if (tryout3 != "")
                                {
                                    tryout4 = component.connectedBody.tag;
                                }
                                else
                                {
                                    tryout3 = component.connectedBody.tag;
                                }
                            }
                            else
                            {
                                tryout2 = component.connectedBody.tag;
                            }
                        }
                        else
                        {
                            tryout = component.connectedBody.tag;
                        }
                    }
                    if (tryout == "Chlorine" && tryout2 == "Chlorine" && tryout3 == "Chlorine" && tryout4 == "Chlorine")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura ccl4 demek
                PlayerPrefs.SetInt("CCl4", 4);
                CorrectPanel.SetActive(true);
                PlayerPrefs.SetInt("CurrentLevel2", 6);
                PlayerPrefs.SetInt("LevelManager2", 6);
            }
            else
            {
                //bura ccl4 yok demek
                FalsePanel.SetActive(true);
            }
            tryout = "";
            tryout2 = "";
            tryout3 = "";
            tryout4 = "";
            final = false;


        }
        else if (PlayerPrefs.GetInt("CurrentLevel2") == 6)
        {
            for (int i = 0; i < rootObjects.Count; ++i)
            {
                GameObject gameObjectnew = rootObjects[i];
                if (gameObjectnew.tag == "Oxygen")
                {
                    foreach (var component in gameObjectnew.GetComponents<FixedJoint>())
                    {
                        if (tryout != "")
                        {
                            tryout2 = component.connectedBody.tag;
                        }
                        else
                        {
                            tryout = component.connectedBody.tag;
                        }
                    }
                    if (tryout == "Chlorine" && tryout2 == "Chlorine")
                    {
                        final = true;
                    }
                }
            }
            if (final == true)
            {
                //bura cl2o demek
                CorrectPanel.SetActive(true);
                PlayerPrefs.SetInt("CurrentLevel2", 7);
                PlayerPrefs.SetInt("LevelManager2", 7);

            }
            else
            {
                //bura cl2o yok demek
                FalsePanel.SetActive(true);
            }
            tryout = "";
            tryout2 = "";
            final = false;

        }
    }
}