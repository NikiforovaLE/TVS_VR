using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo1 : MonoBehaviour
{
    [SerializeField] private Text output;
    [SerializeField] private Text readNumberOne;
    [SerializeField] private Text readNumberTwo;
    [SerializeField] private Text readNumberThree;
    [SerializeField] private Text readNumberFour;
    [SerializeField] private Text readNumberFive;
    [SerializeField] private Button confirm;
    private List<string> containersNumbers;
    private List<Text> readNumbers;
    private int counter;
    private int counterOfReadNumbers;

    public void ReadNumberOfContainer()
    {
        if (counter < 5)
        {
            output.text = containersNumbers[counter];
            counter++;
        }
        else
        {
            counter = 0;
            output.text = containersNumbers[counter];
            counter++;
        }
    }

    public void ConfirmChoice()
    {
        if (counterOfReadNumbers < 5)
        {
            readNumbers[counterOfReadNumbers].text = output.text;
            counterOfReadNumbers++;
        }
        else
        {
            counterOfReadNumbers = 0;
            readNumbers[counterOfReadNumbers].text = output.text;
            counterOfReadNumbers++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        counterOfReadNumbers = 0;
        containersNumbers = new List<string> { "CONT0001", "CONT0002", "CONT0003", "CONT0004", "CONT0005" };
        readNumbers = new List<Text> { readNumberOne, readNumberTwo, readNumberThree, readNumberFour, readNumberFive };
        output.text = "";
    }
}
