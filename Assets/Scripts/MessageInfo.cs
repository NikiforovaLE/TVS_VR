using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageInfo : MonoBehaviour
{
    //[SerializeField] private Text  numOne;
    //[SerializeField] private Text  numTwo;
    //[SerializeField] private Text  numThree;
    //[SerializeField] private Text  numFour;
    //[SerializeField] private Text  numFive;
    //[SerializeField] private Text  numSix;

    //[SerializeField] private Text dateOne;
    //[SerializeField] private Text dateTwo;
    //[SerializeField] private Text dateThree;
    //[SerializeField] private Text dateFour;
    //[SerializeField] private Text dateFive;
    //[SerializeField] private Text dateSix;

    //[SerializeField] private Text timeOne;
    //[SerializeField] private Text timeTwo;
    //[SerializeField] private Text timeThree;
    //[SerializeField] private Text timeFour;
    //[SerializeField] private Text timeFive;
    //[SerializeField] private Text timeSix;

    //[SerializeField] private Text messageOne;
    //[SerializeField] private Text messageTwo;
    //[SerializeField] private Text messageThree;
    //[SerializeField] private Text messageFour;
    //[SerializeField] private Text messageFive;
    //[SerializeField] private Text messageSix;

    //[SerializeField] private Text sourceOne;
    //[SerializeField] private Text sourceTwo;
    //[SerializeField] private Text sourceThree;
    //[SerializeField] private Text sourceFour;
    //[SerializeField] private Text sourceFive;
    //[SerializeField] private Text sourceSix;

    //[SerializeField] private Text statusOne;
    //[SerializeField] private Text statusTwo;
    //[SerializeField] private Text statusThree;
    //[SerializeField] private Text statusFour;
    //[SerializeField] private Text statusFive;
    //[SerializeField] private Text statusSix;

    [SerializeField] private List<Text> numbers = new(6);
    [SerializeField] private List<Text> dates = new(6);
    [SerializeField] private List<Text> time = new(6);
    [SerializeField] private List<Text> textMessages = new(6);
    [SerializeField] private List<Text> sources = new(6);
    [SerializeField] private List<Text> statuses = new(6);

    private int count = 0;
    private int lastNum = 1;

    public void FillInfo(string text, string messageSource, string status)
    {
        if (count < numbers.Capacity)
        {
            FillRow(text, messageSource, status);
            count++;
        }
        else
        {
            count = 0;
            SetCurrentNums();
            MakeAllFieldsEmpty();
            FillRow(text, messageSource, status);
            count++;
        }
    }

    private void FillRow(string text, string messageSource, string status)
    {
        dates[count].text = DateTime.Now.ToShortDateString();
        time[count].text = DateTime.Now.ToLongTimeString();
        textMessages[count].text = text;
        sources[count].text = messageSource;
        statuses[count].text = status;
    }

    // Start is called before the first frame update
    void Start()
    {
        //numbers = new List<Text> { numOne, numTwo, numThree, numFour, numFive, numSix };
        //dates = new List<Text> { dateOne, dateTwo, dateThree, dateFour, dateFive, dateSix };
        //time = new List<Text> { timeOne, timeTwo, timeThree, timeFour, timeFive, timeSix };
        //textMessages = new List<Text> { messageOne, messageTwo, messageThree, messageFour, messageFive, messageSix };
        //sources = new List<Text> { sourceOne, sourceTwo, sourceThree, sourceFour, sourceFive, sourceSix };
        //statuses = new List<Text> { statusOne, statusTwo, statusThree, statusFour, statusFive, statusSix };
        SetCurrentNums();
        MakeAllFieldsEmpty();
    }

    private void MakeAllFieldsEmpty()
    {
        MakeColumnEmpty(dates);
        MakeColumnEmpty(time);
        MakeColumnEmpty(textMessages);
        MakeColumnEmpty(sources);
        MakeColumnEmpty(statuses);
    }

    private void MakeColumnEmpty(List<Text> column)
    {
        foreach (Text val in column)
        {
            val.text = "";
        }
    }

    private void SetCurrentNums()
    {
        foreach (Text num in numbers)
        {
            num.text = lastNum++.ToString();
        }
    }
}
