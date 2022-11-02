using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo31 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private Text containerNumber;

    private int counter;
    public void ShowContainerNumber()
    {
        List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
        int size = chosenContainerNumbers.Count;
        Image currentIndicator = ARM1Mnemo2.Indicators1[counter];
        if (counter < size && currentIndicator.color.Equals(Color.green))
        {
            containerNumber.text = chosenContainerNumbers[counter];
            counter++;
        }
        else
        {
            counter = 0;
            containerNumber.text = chosenContainerNumbers[counter];
            counter++;
        }
    }

    public void ConfirmChoice()
    {
        if (containerNumber.text != "")
        {
            List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
            chosenContainerNumbers.Remove(containerNumber.text);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containerNumber.text = "";
    }
}
