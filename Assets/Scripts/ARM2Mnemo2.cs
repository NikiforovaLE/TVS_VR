using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo2 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnArm2;

    [SerializeField] private Mnemo00Animation Mnemo00Animation;
    [SerializeField] private ARMPanelActions ARM2PanelActions;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private ARM2Mnemo1 ARM2Mnemo1;

    [SerializeField] private Text outputVTUKNumber;
    [SerializeField] private Text outputVTUKNumberOnMnemo3;
    [SerializeField] private Text outputNumberOfFuelElements;
    [SerializeField] private Text infoAboutVTUKNumberOn02Mnemo;
    [SerializeField] private Text arm2Message;

    [SerializeField] private GameObject mainMnemoARM2;
    [SerializeField] private Animator mnemo00Animator;

    private List<string> VTUKNumbers;
    private int counter;

    private string currentVTUK;
    private string currentTotalAmountOfFuelElementsInVTUK;
    private string totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo = "80";
    private string totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour = "51";

    // messages on ARM2 MessageArea
    private readonly string vtuk = "ВТУК ";
    private readonly string isRecieved = " получен на участке подачи комплектующих";
    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public string CurrentVTUK { get => currentVTUK; set => currentVTUK = value; }
    public string CurrentTotalAmountOfFuelElementsInVTUK { get => currentTotalAmountOfFuelElementsInVTUK; set => currentTotalAmountOfFuelElementsInVTUK = value; }

    public void ReadVTUKNumber()
    {
        if (counter < 5)
        {
            outputVTUKNumber.text = VTUKNumbers[counter];
            counter++;
            GetTotalAmountOfFuelElementsInVTUK();
        }
        else
        {
            counter = 0;
            outputVTUKNumber.text = VTUKNumbers[counter];
            GetTotalAmountOfFuelElementsInVTUK();
            counter++;
        }
    }

    public void GetTotalAmountOfFuelElementsInVTUK()
    {
        string Frame = ARM2Mnemo1.CurrentFrame;
        outputNumberOfFuelElements.text = ARM1Mnemo2.FramesAndTypes[Frame] switch
        {
            "1" => totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo,
            "2" => totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo,
            "3" => totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour,
            "4" => totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour,
            _ => ""
        };
    }

    public void ConfirmChoice()
    {
        if (!outputVTUKNumber.text.Equals(""))
        {
            CurrentVTUK = outputVTUKNumber.text;
            outputVTUKNumberOnMnemo3.text = outputVTUKNumber.text;
            currentTotalAmountOfFuelElementsInVTUK = outputNumberOfFuelElements.text;
            ARM2Mnemo0.ShowVTUKInfo();
            ARM2PanelActions.ShowMnemoPanel(mainMnemoARM2);
            arm2Message.text = "";
            infoAboutVTUKNumberOn02Mnemo.text = CurrentVTUK;
            if (mnemo00Animator.GetInteger("VTUKGettingCount") % 2 != 0)
            {
                mnemo00Animator.Play("VTUKGetting");
                //mnemo01AnimationController.Mnemo01OffMnemo02Andnemo03On();
            }

            //Mnemo 00 actions
            Mnemo00Animation.ToBeYellowTwo = false;
            Mnemo00Animation.AttentionMessageTwo.text = "";

            //messageInfoOnArm2.FillInfo(vtuk + CurrentVTUK + isRecieved, messageSourceIsOperator, positiveStatus);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        CurrentVTUK = "";
        VTUKNumbers = new List<string> { "ВТУК0001", "ВТУК0002", "ВТУК0003", "ВТУК0004", "ВТУК0005" };
        infoAboutVTUKNumberOn02Mnemo.text = "";
    }
}
