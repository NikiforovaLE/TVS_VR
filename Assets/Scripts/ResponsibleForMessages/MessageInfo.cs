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

    [HideInInspector] private const int SIZE = 6;
    [SerializeField] private Text[] numbers = new Text[SIZE];
    [SerializeField] private Text[] dates = new Text[SIZE];
    [SerializeField] private Text[] time = new Text[SIZE];
    [SerializeField] private Text[] textMessages = new Text[SIZE];
    [SerializeField] private Text[] sources = new Text[SIZE];
    [SerializeField] private Text[] statuses = new Text[SIZE];

    private int count = 0;
    private int lastNum = 1;

    public void FillInfo(string text, string messageSource, string status)
    {
        if (count < numbers.Length)
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

    private void MakeColumnEmpty(Text[] column)
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
