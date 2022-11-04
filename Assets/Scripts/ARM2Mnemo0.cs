using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo0 : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo1 ARM2Mnemo1;
    [SerializeField] private ARM2Mnemo2 ARM2Mnemo2;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;

    [SerializeField] private Text frameNumber;
    [SerializeField] private Text type;
    [SerializeField] private Text currentAmountOfFuelElementsInTVS;
    [SerializeField] private Text totalAmountOfFuelElementsInTVS;

    [SerializeField] private Text VTUKNumber;
    [SerializeField] private Text currentAmountOfFuelElementsInVTUK;
    [SerializeField] private Text totalAmountOfFuelElementsInVTUK;

    private string totalAmountOfFuelElementsInTVSWhenTypeOneAndTwo;
    private string totalAmountOfFuelElementsInTVSWhenTypeThreeAndFour;
    public void ShowTVSInfo()
    {
        string currentFrameOfTVS = ARM2Mnemo1.CurrentFrame;
        frameNumber.text = currentFrameOfTVS;
        type.text = ARM1Mnemo2.FramesAndTypes[currentFrameOfTVS];
        GetTotalAmountOfFuelElementsInTVS();
        currentAmountOfFuelElementsInTVS.text = "0";
    }

    public void ShowVTUKInfo()
    {
        VTUKNumber.text = ARM2Mnemo2.CurrentVTUK;
        totalAmountOfFuelElementsInVTUK.text = ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK;
        currentAmountOfFuelElementsInVTUK.text = totalAmountOfFuelElementsInVTUK.text;
    }

    public void GetTotalAmountOfFuelElementsInTVS()
    {
        totalAmountOfFuelElementsInTVS.text = type.text switch
        {
            "1" => totalAmountOfFuelElementsInTVSWhenTypeOneAndTwo,
            "2" => totalAmountOfFuelElementsInTVSWhenTypeOneAndTwo,
            "3" => totalAmountOfFuelElementsInTVSWhenTypeThreeAndFour,
            "4" => totalAmountOfFuelElementsInTVSWhenTypeThreeAndFour,
            _ => ""
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        totalAmountOfFuelElementsInTVSWhenTypeOneAndTwo = "160";
        totalAmountOfFuelElementsInTVSWhenTypeThreeAndFour = "102";
        frameNumber.text = "";
        type.text = "";
    }
}
