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

    // Start is called before the first frame update
    void Start()
    {
        TrueAction = openTruePanel;
        FalseAction = openFalsePanel;
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
            first.SetText("2,5");
            second.SetText("4,1");
            third.SetText("9,7");
            fourth.SetText("14,1");
            first1.GetComponent<Button>().onClick.AddListener(FalseAction);
            second2.GetComponent<Button>().onClick.AddListener(FalseAction);
            third3.GetComponent<Button>().onClick.AddListener(TrueAction);
            forth4.GetComponent<Button>().onClick.AddListener(FalseAction);
        }
    }
    void openTruePanel()
    {
        Debug.Log("Tavukcu");
        True.SetActive(true);
        //PlayerPrefs.SetInt("CurrentLevel", PlayerPrefs.GetInt("CurrentLevel") + 1);
    }
    void openFalsePanel()
    {
        Debug.Log("Tavukcu");
        False.SetActive(true);
    }
}
