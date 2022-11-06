using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo2 : MonoBehaviour
{
    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private ARMPanelActions ARMPanelActions;
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;

    [SerializeField] private Text containerNumber;
    [SerializeField] private Text frameNumber;
    [SerializeField] private Text attention;

    [SerializeField] private Image indicatorOne;
    [SerializeField] private Image indicatorTwo;
    [SerializeField] private Image indicatorThree;
    [SerializeField] private Image indicatorFour;
    [SerializeField] private Image indicatorFive;

    [SerializeField] private Dropdown menuOfTVSTypes;
    
    private int counter;
    private int containersCounter;
    private int framesCounter;
    private string typeOfTVS;
    private string whenDefects;
    private List<string> framesNumbers;
    private List<Image> Indicators;
    private bool Scratches;
    private bool Dints;
    private bool DefectsInFixing;
    private Dictionary<string, bool> resultOfControl;
    private Dictionary<string, string> numberOfContainersAndFrames;
    private Dictionary<string, string> framesAndTypes;
    public bool Scratches1 { get => Scratches; set => Scratches = value; }
    public bool Dints1 { get => Dints; set => Dints = value; }
    public bool DefectsInFixing1 { get => DefectsInFixing; set => DefectsInFixing = value; }
    public Dictionary<string, string> NumberOfContainersAndFrames { get => numberOfContainersAndFrames; set => numberOfContainersAndFrames = value; }
    public Dictionary<string, bool> ResultOfControl { get => resultOfControl; set => resultOfControl = value; }
    public List<Image> Indicators1 { get => Indicators; set => Indicators = value; }
    public string TypeOfTVS { get => typeOfTVS; set => typeOfTVS = value; }
    public Dictionary<string, string> FramesAndTypes { get => framesAndTypes; set => framesAndTypes = value; }

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
            ARMPanelActions.ShowMnemoPanel(mainARM1Mnemo);
        }
        else 
        {
            attention.text = "";
            Indicators[indexOfIndicator].color = Color.green;
            ResultOfControl.Add(Container, false);
            NumberOfContainersAndFrames.Add(Container, Frame);
            FramesAndTypes.Add(Frame, TypeOfTVS);
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

    public void ChooseType()
    {
        TypeOfTVS = menuOfTVSTypes.options[menuOfTVSTypes.value].text;
    }
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containersCounter = 0;
        framesCounter = 0;
        whenDefects = "x";
        attention.text = "";
        TypeOfTVS = "";
        framesNumbers = new List<string> { "TVS00001", "TVS00002", "TVS00003", "TVS00004", "TVS00005" };
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
    }
}
