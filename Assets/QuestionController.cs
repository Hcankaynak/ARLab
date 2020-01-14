using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuestionController : MonoBehaviour
{
    
	public TextMeshProUGUI first;
	public TextMeshProUGUI second;
	public TextMeshProUGUI third;
	public TextMeshProUGUI fourth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (PlayerPrefs.GetInt("CurrentLevel") == 1)
		{
            first.SetText("2");
            second.SetText("5");
            third.SetText("9");
            fourth.SetText("14");
			
		}
		else if (PlayerPrefs.GetInt("CurrentLevel") == 2)
		{
            first.SetText("3");
            second.SetText("5");
            third.SetText("7");
            fourth.SetText("11");
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            first.SetText("1");
            second.SetText("5");
            third.SetText("9");
            fourth.SetText("11");
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            first.SetText("2");
            second.SetText("4");
            third.SetText("8");
            fourth.SetText("14");
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            first.SetText("1");
            second.SetText("3");
            third.SetText("11");
            fourth.SetText("14");
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            first.SetText("2");
            second.SetText("4");
            third.SetText("10");
            fourth.SetText("14");
        }
    }
}
