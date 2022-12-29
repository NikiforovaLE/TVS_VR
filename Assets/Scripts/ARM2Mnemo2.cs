using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo2 : MonoBehaviour
{
    [SerializeField] private Text outputVTUKNumber;
    [SerializeField] private Text outputVTUKNumberOnMnemo3;
    [SerializeField] private Text outputNumberOfFuelElements;
    [SerializeField] private Text message;
    [SerializeField] private Text generalMessage;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private ARM2Mnemo1 ARM2Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARMPanelActions ARM2PanelActions;
    [SerializeField] private GameObject mainMnemoARM2;
    [SerializeField] private Text infoAboutVTUKNumberOn02Mnemo;

    private List<string> VTUKNumbers;

    private readonly string generalMessageAfterConfirm = "Посмотрите 2D и 3D анимации";
    private string currentVTUK;
    private string currentTotalAmountOfFuelElementsInVTUK;
    private string totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo;
    private string totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour;
    private int counter;

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
            message.text = "";
            generalMessage.text = generalMessageAfterConfirm;
            infoAboutVTUKNumberOn02Mnemo.text = CurrentVTUK;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        CurrentVTUK = "";
        VTUKNumbers = new List<string> { "VTUK0001", "VTUK0002", "VTUK0003", "VTUK0004", "VTUK0005" };
        totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo = "80";
        totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour = "51";
        infoAboutVTUKNumberOn02Mnemo.text = "";
    }
}
