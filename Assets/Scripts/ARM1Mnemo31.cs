using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo31 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo01MainPanel;
    [SerializeField] private MessageInfo messageInfoOnArm1;

    [SerializeField] private ARM1Mnemo0 arm1Mnemo0;
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARMPanelActions ARM1PanelActions;

    [SerializeField] private Text containerNumber;
    [SerializeField] private Text arm2Message;
    [SerializeField] private Text infoAboutContainerNumberOnMnemo01;
    [SerializeField] private Text attention;
    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;

    private int counter;
    private string currentContainer;

    // messages on TopPanels
    private readonly string arm2OperationsMustBePerformed = "Необходимо выполнить операции на АРМ ввода №2";
    private readonly string arm2InitialMessage = "Необходимо получить контейнер с каркасом ТВС";

    private readonly string warningMessage = "Сначала нужно считать номер контейнера!";

    // messages on the MessageArea on Mnemo01 on Main panel
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

            //TopPanels
            arm1Mnemo0.ShowMessageOnArmlMessagePanel(arm2OperationsMustBePerformed);
            arm2Message.text = arm2InitialMessage;

            //info on Mnemo01
            infoAboutContainerNumberOnMnemo01.text = CurrentContainer;
            messageInfoOnMnemo01MainPanel.FillInfo(operatorAllowedOperations, messageSourceIsOperator, positiveStatus);

            messageInfoOnArm1.FillInfo(containerText + CurrentContainer + isTransferred, messageSourceIsOperator, positiveStatus);// messageArea

            //Mnemo 00 actions
            Mnemo00Animation.StopBlinkingOneStartBlinkingTwo();
            //Mnemo00Animation.ToBeYellowOne = false;
            //Mnemo00Animation.ToBeYellowTwo = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containerNumber.text = "";
        CurrentContainer = "";
        infoAboutContainerNumberOnMnemo01.text = "";
        attention.text = "";
    }
}
