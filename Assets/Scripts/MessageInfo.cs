using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageInfo : MonoBehaviour
{
    [SerializeField] private Text  numOne;
    [SerializeField] private Text  numTwo;
    [SerializeField] private Text  numThree;
    [SerializeField] private Text  numFour;

    [SerializeField] private Text dateOne;
    [SerializeField] private Text dateTwo;
    [SerializeField] private Text dateThree;
    [SerializeField] private Text dateFour;

    [SerializeField] private Text timeOne;
    [SerializeField] private Text timeTwo;
    [SerializeField] private Text timeThree;
    [SerializeField] private Text timeFour;

    [SerializeField] private Text messageOne;
    [SerializeField] private Text messageTwo;
    [SerializeField] private Text messageThree;
    [SerializeField] private Text messageFour;

    [SerializeField] private Text statusOne;
    [SerializeField] private Text statusTwo;
    [SerializeField] private Text statusThree;
    [SerializeField] private Text statusFour;

    private List<Text> numbers;
    private List<Text> dates;
    private List<Text> time;
    private List<Text> textMessages;
    private List<Text> statuses;

    private int count = 0;
    private int lastNum = 1;

    public void FillInfo(string text, string status)
    {
        if (count < 4)
        {
            FillRow(text, status);
            count++;
        }
        else
        {
            count = 0;
            SetCurrentNums();
            FillRow(text, status);
            count++;
        }
    }

    private void FillRow(string text, string status)
    {
        dates[count].text = DateTime.Now.ToShortDateString();
        time[count].text = DateTime.Now.ToShortTimeString();
        textMessages[count].text = text;
        statuses[count].text = status;
    }

    // Start is called before the first frame update
    void Start()
    {
        numbers = new List<Text> {  numOne,  numTwo,  numThree,  numFour };
        dates = new List<Text> { dateOne, dateTwo, dateThree, dateFour };
        time = new List<Text> { timeOne, timeTwo, timeThree, timeFour };
        textMessages = new List<Text> { messageOne, messageTwo, messageThree, messageFour };
        statuses = new List<Text> { statusOne, statusTwo, statusThree, statusFour };
        SetCurrentNums();
        SetIniialInfo(dates);
        SetIniialInfo(time);
        SetIniialInfo(textMessages);
        SetIniialInfo(statuses);
    }

    private void SetCurrentNums()
    {
        foreach (Text num in numbers) {
            num.text = lastNum++.ToString();
        }
    }

    private void SetIniialInfo(List<Text> column)
    {
        foreach (Text val in column)
        {
            val.text = "";
        }
    }
}
