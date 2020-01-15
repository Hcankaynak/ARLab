using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InstructionManager : MonoBehaviour
{
    public GameObject Welcome;
    public GameObject Description;
    public GameObject InstructorPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.HasKey("CurrentLevel2"))
        {
            if (PlayerPrefs.GetInt("CurrentLevel2") == 1)
            {

                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 1");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Water\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n"+
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 2)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 2");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Methane\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n" +
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 3)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 3");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Hydrogen Cloride\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n" +
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 4)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 4");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Ammonia\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n" +
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 5)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 5");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Carbon TetraChloride\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n" +
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 6)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 6");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Dichloride Monoxide\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct atoms then\n" +
                    "4. Connect correct atoms between\n" +
                    "5. Finally Create press play button at top right corner if you do it right you will pass to next level.\n" +
                    "6. Have fun good luck!");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel2") == 0)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Free Mode");
                Description.GetComponent<TextMeshProUGUI>().SetText("You can do whatever you want in here.");
            }
        }
        else
        {
            InstructorPanel.SetActive(true);
            Debug.Log("else");
        }
    }
}
