using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo31 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo1MainPanel;
    [SerializeField] private MessageInfo messageInfoOnArm1;

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

    private int counter;
    private string currentContainer;

    // messages on the top panels
    private readonly string messageOnArm1TopPanelWhenConfirm = "";
    private readonly string generalMessageAfterConfirm = "Необходимо выполнить операции на АРМ ввода №2";
    private readonly string ARM2MessageAfterConfirm = "Необходимо получить контейнер с каркасом ТВС";
    private readonly string warningMessage = "Сначала нужно считать номер контейнера!";

    // messages on the MessageArea on Mnemo1 on Main panel
    private readonly string operatorAllowedOperations = "Оператор разрешил выполнение операций на ЛСУ";

    // messages on ARM1 MessageArea
    private readonly string containerText = "Контейнер ";
    private readonly string isTransferred = " передан на участок ПТиК";

    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

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

            //top panel messages
            messageOnARM1TopPanel.text = messageOnArm1TopPanelWhenConfirm;
            generalMessage.text = generalMessageAfterConfirm;
            ARM2Message.text = ARM2MessageAfterConfirm;

            //info on 01 Mnemo
            infoAboutContainerNumberOn01Mnemo.text = CurrentContainer;
            messageInfoOnMnemo1MainPanel.FillInfo(operatorAllowedOperations, messageSourceIsOperator, positiveStatus);

            //messageInfoOnArm1.FillInfo(containerText + CurrentContainer + isTransferred, messageSourceIsOperator, positiveStatus);// messageArea

            //Mnemo 00 actions
            Mnemo00Animation.ToBeYellowOne = false;
            Mnemo00Animation.ToBeYellowTwo = true;
            Mnemo00Animation.AttentionMessageOne.text = "";
            Mnemo00Animation.AttentionMessageTwo.text = generalMessageAfterConfirm;
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
