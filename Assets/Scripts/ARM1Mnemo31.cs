using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo31 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARMPanelActions ARM1PanelActions;
    [SerializeField] private Text containerNumber;
    [SerializeField] private GameObject mainARM1Mnemo;

    private string currentContainer;
    private int counter;

    public string CurrentContainer { get => currentContainer; set => currentContainer = value; }

    public void ShowContainerNumber()
    {
        List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
        int size = chosenContainerNumbers.Count;
        Image currentIndicator = ARM1Mnemo2.Indicators1[counter];
        if (counter == size - 1)
        {
            WriteInContainerNumber(currentIndicator, chosenContainerNumbers);
            counter = 0;
        }
        else if (counter < size)
        {
            WriteInContainerNumber(currentIndicator, chosenContainerNumbers);
            counter++;
        }
    }

    private void WriteInContainerNumber(Image currentIndicator, List<string> chosenContNumbers)
    {
        if (currentIndicator.color.Equals(Color.green))
        {
            containerNumber.text = chosenContNumbers[counter];
        }
    }

    public void ConfirmChoice()
    {
            List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
            CurrentContainer = containerNumber.text;
            chosenContainerNumbers.Remove(CurrentContainer);
            ARM1PanelActions.ShowMnemoPanel(mainARM1Mnemo);
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containerNumber.text = "";
        CurrentContainer = "";
    }
}
