using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo2 : MonoBehaviour
{
    [SerializeField] private Text outputVTUKNumber;
    [SerializeField] private Text outputNumberOfFuelElements;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private ARM2Mnemo1 ARM2Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;

    private List<string> VTUKNumbers;

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
        CurrentVTUK = outputVTUKNumber.text;
        currentTotalAmountOfFuelElementsInVTUK = outputNumberOfFuelElements.text;
        ARM2Mnemo0.ShowVTUKInfo();
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        CurrentVTUK = "";
        VTUKNumbers = new List<string> { "VTUK0001", "VTUK0002", "VTUK0003", "VTUK0004", "VTUK0005" };
        totalAmountOfFuelElementsInVTUKWhenTypeOneAndTwo = "80";
        totalAmountOfFuelElementsInVTUKWhenTypeThreeAndFour = "51";
    }
}
