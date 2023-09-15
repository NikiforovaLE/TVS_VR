using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo1 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnArm1;

    [SerializeField] private Text output;
    [SerializeField] private Text message;
    [SerializeField] private Text generalMessage;
    [SerializeField] private Text readNumberOne;
    [SerializeField] private Text readNumberTwo;
    [SerializeField] private Text readNumberThree;
    [SerializeField] private Text readNumberFour;
    [SerializeField] private Text readNumberFive;
    [SerializeField] private Text attention;
    [SerializeField] private Text numberOnMnemo0;

    [SerializeField] private ARMPanelActions ARMPanelActions;

    private List<string> containersNumbers;
    private List<Text> readNumbers;
    private List<string> chosenNumbers;

    private int counter;
    private int counterOfReadNumbers;

    // messages on the top panels
    private readonly string firstGeneralMessage = "Необходимо выполнить операции на АРМ ввода №1";
    private readonly string firstMessageOnArm1TopPanel = "Требуется получить контейнер с каркасом ТВС";
    private readonly string afterConfirmMessageOnArm1TopPanel = "Требуется выполнить входной контроль";
    private readonly string warningMessage = "Сначала нужно считать номер контейнера!";

    // messages on ARM1 MessageArea
    private readonly string containerIsRecieved = "Получен контейнер ";
    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public List<string> ChosenNumbers { get => chosenNumbers; set => chosenNumbers = value; }
    public List<Text> ReadNumbers { get => readNumbers; set => readNumbers = value; }
    public int CounterOfReadNumbers { get => counterOfReadNumbers; set => counterOfReadNumbers = value; }

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

    public void ConfirmChoice(GameObject mainARM1Mnemo)
    {
        if (output.text.Equals(""))
        {
            attention.color = Color.red;
            attention.text = warningMessage;
            return;
        }

        if (CounterOfReadNumbers < 5 && !ChosenNumbers.Contains(output.text))
        {
            attention.text = "";
            string currentContainer = output.text;
            ReadNumbers[CounterOfReadNumbers++].text = currentContainer;
            ChosenNumbers.Add(currentContainer);
            message.text = afterConfirmMessageOnArm1TopPanel; // message on the ARM1 top panel
            numberOnMnemo0.text = CounterOfReadNumbers.ToString(); // info on ARM1Mnemo0

            //fill messageArea on ARM1 
            //messageInfoOnArm1.FillInfo(containerIsRecieved + currentContainer, messageSourceIsOperator, positiveStatus);

            ARMPanelActions.ShowMnemoPanel(mainARM1Mnemo);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        CounterOfReadNumbers = 0;
        output.text = "";
        readNumberOne.text = "";
        readNumberTwo.text = "";
        readNumberThree.text = "";
        readNumberFour.text = "";
        readNumberFive.text = "";
        attention.text = "";
        numberOnMnemo0.text = 0.ToString();
        message.text = firstMessageOnArm1TopPanel;
        generalMessage.text = firstGeneralMessage;
        containersNumbers = new List<string> { "КОНТ0001", "КОНТ0002", "КОНТ0003", "КОНТ0004", "КОНТ0005" };
        ReadNumbers = new List<Text> { readNumberOne, readNumberTwo, readNumberThree, readNumberFour, readNumberFive };
        ChosenNumbers = new List<string>();
    }
}
