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
    [SerializeField] private Text messageOnARM1TopPanel;
    [SerializeField] private Text generalMessage;
    [SerializeField] private Text ARM2Message;
    [SerializeField] private Text infoAboutContainerNumberOn01Mnemo;
    [SerializeField] private Text attention;
    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;
    private string currentContainer;
    private readonly string messageWhenConfirm = "";
    private readonly string generalMessageAfterConfirm = "Необходимо выполнить операции на АРМ ввода №2";
    private readonly string ARM2MessageAfterConfirm = "Необходимо получить контейнер с каркасом ТВС";
    private readonly string warningMessage = "Сначала нужно считать номер контейнера!";
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
        if (containerNumber.text.Equals(""))
        {
            attention.color = Color.red;
            attention.text = warningMessage;
        }
        else
        {
            attention.text = "";
            List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
            CurrentContainer = containerNumber.text;
            chosenContainerNumbers.Remove(CurrentContainer);
            ARM1PanelActions.ShowMnemoPanel(mainARM1Mnemo);
            messageOnARM1TopPanel.text = messageWhenConfirm;
            generalMessage.text = generalMessageAfterConfirm;
            ARM2Message.text = ARM2MessageAfterConfirm;
            infoAboutContainerNumberOn01Mnemo.text = CurrentContainer;
            Mnemo00Animation.ToBeYellow = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containerNumber.text = "";
        CurrentContainer = "";
        infoAboutContainerNumberOn01Mnemo.text = "";
        attention.text = "";
    }
}
