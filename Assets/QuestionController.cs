using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class QuestionController : MonoBehaviour
{
    private UnityAction FalseAction;
    private UnityAction TrueAction;
    public GameObject True;
    public GameObject False;
	public TextMeshProUGUI first;
    public GameObject first1;
	public TextMeshProUGUI second;
    public GameObject second2;
    public TextMeshProUGUI third;
    public GameObject third3;
    public TextMeshProUGUI fourth;
    public GameObject forth4;
    bool oneTime;
    public GameObject Instructor;
    public GameObject Home;
    public GameObject Add;
    public GameObject QuestionPanel;

    // Start is called before the first frame update
    void Start()
    {
        TrueAction = openTruePanel;
        FalseAction = openFalsePanel;
        oneTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        
		if (PlayerPrefs.GetInt("CurrentLevel") == 1)
		{
            
            first.SetText("1");
            second.SetText("5");
            third.SetText("9");
            fourth.SetText("14");
            first1.GetComponent<Button>().onClick.AddListener(TrueAction);
            second2.GetComponent<Button>().onClick.AddListener(FalseAction);
            third3.GetComponent<Button>().onClick.AddListener(FalseAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
            //first1.onClick.AddListener(myAction);

        }
		else if (PlayerPrefs.GetInt("CurrentLevel") == 2)
		{
            oneTime = true;
            first.SetText("0,4");
            second.SetText("2,6");
            third.SetText("5,3");
            fourth.SetText("11,9");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(TrueAction);
            third3.GetComponent<Button>().onClick.AddListener(FalseAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            oneTime = true;
            first.SetText("2.02");
            second.SetText("5,45");
            third.SetText("9,90");
            fourth.SetText("11.0");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(TrueAction);
            third3.GetComponent<Button>().onClick.AddListener(FalseAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            oneTime = true;
            first.SetText("2,5");
            second.SetText("4,1");
            third.SetText("8,3");
            fourth.SetText("14,6");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(FalseAction);
            third3.GetComponent<Button>().onClick.AddListener(TrueAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            oneTime = true;
            first.SetText("1");
            second.SetText("3");
            third.SetText("11");
            fourth.SetText("14");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(FalseAction);
            third3.GetComponent<Button>().onClick.AddListener(TrueAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            oneTime = true;
            first.SetText("2,5");
            second.SetText("4,1");
            third.SetText("9,7");
            fourth.SetText("14,1");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(FalseAction);
            third3.GetComponent<Button>().onClick.AddListener(TrueAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 0)
        {
            oneTime = true;
            Home.SetActive(true);
            Add.SetActive(true);
            Instructor.SetActive(false);
        }

    }
    void openTruePanel()
    {
        if (oneTime)
        {
            PlayerPrefs.SetInt("level2", 4);
            QuestionPanel.SetActive(false);
            True.SetActive(true);
            int temp = PlayerPrefs.GetInt("CurrentLevel");
            temp += 1;
            PlayerPrefs.SetInt("CurrentLevel", temp);
            
            int level = PlayerPrefs.GetInt("LevelManager");
            level += 1;
            Debug.Log("Burasıııı" + level);
            PlayerPrefs.SetInt("LevelManager", level);
            oneTime = false;
        }
        
    }
    void openFalsePanel()
    {
        QuestionPanel.SetActive(false);
        False.SetActive(true);
    }
}
