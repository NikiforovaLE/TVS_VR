using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo2 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnArm1;

    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private ARMPanelActions ARMPanelActions;
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;

    [SerializeField] private Text containerNumber;
    [SerializeField] private Text frameNumber;
    [SerializeField] private Text attention;
    [SerializeField] private Text message;
    [SerializeField] private Text chosenType;

    [SerializeField] private Image indicatorOne;
    [SerializeField] private Image indicatorTwo;
    [SerializeField] private Image indicatorThree;
    [SerializeField] private Image indicatorFour;
    [SerializeField] private Image indicatorFive;

    [SerializeField] private GameObject types;

    private int counter;
    private int containersCounter;
    private int framesCounter;
    private string typeOfTVS;
    private bool Scratches;
    private bool Dints;
    private bool DefectsInFixing;

    private List<string> framesNumbers;
    private List<string> deffectContainers;
    private List<Image> Indicators;
    private Dictionary<string, bool> resultOfControl; //does TVS have defects? yes-true, no - false
    private Dictionary<string, string> numberOfContainersAndFrames;
    private Dictionary<string, List<string>> deffectContainerNumbersAndListOfItsFramesAndTypes;
    private Dictionary<string, string> framesAndTypes;

    private readonly string messageWhenConfirmWithoutDeffects = "Требуется передать контейнер на участок ПТиК";
    private readonly string messageWhenConfirmWithDeffects = "Требуется выбрать контейнер без дефектов и передать его на участок ПТиК";
    private readonly string whenDefects = "x";
    private readonly string type1 = "1";
    private readonly string type2 = "2";
    private readonly string type3 = "3";
    private readonly string type4 = "4";

    // messages on ARM1 MessageArea
    private readonly string containerIsRecieved = "Получен контейнер ";
    private readonly string inputControl = "Входной контроль каркаса  ";
    private readonly string fromContainer = " из контейнера  ";
    private readonly string isPerformedNoDefects = " выполнен, дефектов нет";
    private readonly string isPerformedWithDefects = " выполнен, обнаружены дефекты";
    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public bool Scratches1 { get => Scratches; set => Scratches = value; }
    public bool Dints1 { get => Dints; set => Dints = value; }
    public bool DefectsInFixing1 { get => DefectsInFixing; set => DefectsInFixing = value; }
    public Dictionary<string, string> NumberOfContainersAndFrames { get => numberOfContainersAndFrames; set => numberOfContainersAndFrames = value; }
    public Dictionary<string, bool> ResultOfControl { get => resultOfControl; set => resultOfControl = value; }
    public List<Image> Indicators1 { get => Indicators; set => Indicators = value; }
    public string TypeOfTVS { get => typeOfTVS; set => typeOfTVS = value; }
    public Dictionary<string, string> FramesAndTypes { get => framesAndTypes; set => framesAndTypes = value; }
    public Dictionary<string, List<string>> DeffectContainerNumbersAndListOfItsFramesAndTypes { get => deffectContainerNumbersAndListOfItsFramesAndTypes; set => deffectContainerNumbersAndListOfItsFramesAndTypes = value; }
    public List<string> DeffectContainers { get => deffectContainers; set => deffectContainers = value; }

    public void ShowContainerNumbers()
    {
        List<string> chosenContainerNumbers = ARM1Mnemo1.ChosenNumbers;
        int size = chosenContainerNumbers.Count;
        if (counter % 2 == 0 && containersCounter < size)
        {
            containerNumber.text = chosenContainerNumbers[containersCounter];
            containersCounter++;
            counter++;
        }
        else if (counter % 2 == 0 && containersCounter >= size)
        {
            containersCounter = 0;
            containerNumber.text = chosenContainerNumbers[containersCounter];
            containersCounter++;
            counter++;
        }
        else
        {
            ShowFrameNumber();
        }
    }

    public void ShowFrameNumber()
    {
        if (framesCounter < 5)
        {
            ShowFrameNumberText();
        }
        else
        {
            framesCounter = 0;
            ShowFrameNumberText();
        }
    }

    private void ShowFrameNumberText()
    {
        frameNumber.text = framesNumbers[framesCounter];
        framesCounter++;
        counter++;
    }

    public void ConfirmYourChoice()
    {
        string Container = containerNumber.text;
        string Frame = frameNumber.text;
        int indexOfIndicator = ARM1Mnemo1.ChosenNumbers.IndexOf(Container);
        if (Container.Equals("") || Frame.Equals(""))
        {
            attention.color = Color.red;
            attention.text = "Необходимо считать номера";
            return;
        }

        if (TypeOfTVS.Equals(""))
        {
            attention.color = Color.red;
            attention.text = "Сначала выберите исполнение ТВС!";
            return;
        }

        if (IsDefects())
        {
            attention.text = "";
            ResultOfControl.Add(Container, true);
            Indicators[indexOfIndicator].color = Color.red;
            DeffectContainers.Add(Container);
            DeffectContainerNumbersAndListOfItsFramesAndTypes.Add(Container, new List<string> { Frame, TypeOfTVS });
            message.text = messageWhenConfirmWithDeffects; // message on the ARM1 top panel
            messageInfoOnArm1.FillInfo(inputControl + Frame + fromContainer + Container + isPerformedWithDefects, messageSourceIsOperator, negativeStatus); //messageArea
            ARMPanelActions.ShowMnemoPanel(mainARM1Mnemo);
        }
        else
        {
            attention.text = "";
            Indicators[indexOfIndicator].color = Color.green;
            ResultOfControl.Add(Container, false);
            NumberOfContainersAndFrames.Add(Container, Frame);
            FramesAndTypes.Add(Frame, TypeOfTVS);
            message.text = messageWhenConfirmWithoutDeffects; // message on the ARM1 top panel
            messageInfoOnArm1.FillInfo(containerIsRecieved + Container, messageSourceIsOperator, positiveStatus); //messageArea
            messageInfoOnArm1.FillInfo(inputControl + Frame + fromContainer + Container + isPerformedNoDefects, messageSourceIsOperator, positiveStatus); //messageArea
            ARMPanelActions.ShowMnemoPanel(mainARM1Mnemo);
        }
    }

    public void AddScratches(Text buttonText)
    {
        Scratches = !Scratches;
        buttonText.text = Scratches ? whenDefects : "";
    }

    public void AddDints(Text buttonText)
    {
        Dints = !Dints;
        buttonText.text = Dints ? whenDefects : "";
    }

    public void AddDefectsInFixing(Text buttonText)
    {
        DefectsInFixing = !DefectsInFixing;
        buttonText.text = DefectsInFixing ? whenDefects : "";
    }
    private bool IsDefects()
    {
        return Scratches || Dints || DefectsInFixing;
    }

    public void ShowTypesMenu()
    {
        types.SetActive(true);
    }

    public void ChooseType1()
    {
        ChooseType(type1);
    }

    public void ChooseType2()
    {
        ChooseType(type2);
    }
    public void ChooseType3()
    {
        ChooseType(type3);
    }
    public void ChooseType4()
    {
        ChooseType(type4);
    }

    private void ChooseType(string type)
    {
        TypeOfTVS = type;
        types.SetActive(false);
        chosenType.text = type;
    }
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containersCounter = 0;
        framesCounter = 0;
        attention.text = "";
        TypeOfTVS = "";
        framesNumbers = new List<string> { "ТВС00001", "ТВС00002", "ТВС00003", "ТВС00004", "ТВС00005" };
        Scratches = false;
        Dints = false;
        DefectsInFixing = false;
        ResultOfControl = new Dictionary<string, bool>();
        NumberOfContainersAndFrames = new Dictionary<string, string>();
        FramesAndTypes = new Dictionary<string, string>();
        Indicators = new List<Image> { indicatorOne, indicatorTwo, indicatorThree, indicatorFour, indicatorFive };
        for (int i = 0; i < Indicators.Count; i++)
        {
            Indicators[i].color = Color.gray;
        }
        types.SetActive(false);
        chosenType.text = "";
    }
}
