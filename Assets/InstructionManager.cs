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
        
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            if (PlayerPrefs.GetInt("CurrentLevel") == 1)
            {

                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 1");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Hydrogen chloride\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n"+
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 2)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 2");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Cola\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n" +
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 3");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Listerin\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n" +
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 4");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Soda\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n" +
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 5");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create an Ammonia\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n" +
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("Welcome to Level 6");
                Description.GetComponent<TextMeshProUGUI>().SetText("1. In this chapter we want you to the create a Detergent Water\n" +
                    "2. You can start with pressing " + " button at right bottom corner\n" +
                    "3. First you need to create correct flask then\n" +
                    "4. Create a syringe to take sample\n" +
                    "5. Finally Create a litmus paper and test your sample after you are sure press the top right button to answer the question.\n" +
                    "6. Have fun good luck, we will see at ending this experiment.");
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
            {
                Welcome.GetComponent<TextMeshProUGUI>().SetText("");
                Description.GetComponent<TextMeshProUGUI>().SetText("");
            }
        }
        else
        {

        }
    }
}
