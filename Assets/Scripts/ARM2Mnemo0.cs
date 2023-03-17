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

    //info in 04.Mnemo in MainPanel(copy)
    [SerializeField] private Text TVSFrameNumberInfoIn04Mnemo;
    [SerializeField] private Text TVSTypeInfoIn04Mnemo;
    [SerializeField] private Text EquippedFuelRodsInfoIn04Mnemo;

    //info in 02.Mnemo in MainPanel
    [SerializeField] private Text VTUKNumberInfoIn02Mnemo;

    private readonly string typeOneAndTwoTotalAmountOfFuelElements = "160";
    private readonly string typeThreeAndFourTotalAmountOfFuelElements = "102";

    public Text FrameNumber { get => frameNumber; set => frameNumber = value; }
    public Text Type { get => type; set => type = value; }

    public void ShowTVSInfo()
    {
        //Get needed info
        string currentFrameOfTVS = ARM2Mnemo1.CurrentFrame;
        string typeOfTVS = ARM1Mnemo2.FramesAndTypes[currentFrameOfTVS];

        //Add info to 0.Mnemo in ARM2MainPanel
        FrameNumber.text = currentFrameOfTVS;
        Type.text = typeOfTVS;
        GetAndSetTotalAmountOfFuelElementsInTVS();
        currentAmountOfFuelElementsInTVS.text = "0";

        //Add info to 04.Mnemo in MainPanel(copy)
        TVSFrameNumberInfoIn04Mnemo.text = currentFrameOfTVS;
        TVSTypeInfoIn04Mnemo.text = typeOfTVS;
        EquippedFuelRodsInfoIn04Mnemo.text = "0";
    }

    public void ShowVTUKInfo()
    {
        //Get VTUK number
        string currentVTUK = ARM2Mnemo2.CurrentVTUK;

        //Add info to 0.Mnemo in ARM2MainPanel
        VTUKNumber.text = currentVTUK;
        totalAmountOfFuelElementsInVTUK.text = ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK;
        currentAmountOfFuelElementsInVTUK.text = totalAmountOfFuelElementsInVTUK.text;

        //Add info to 02.Mnemo in MainPanel
        VTUKNumberInfoIn02Mnemo.text = currentVTUK;
    }

    public void GetAndSetTotalAmountOfFuelElementsInTVS()
    {
        totalAmountOfFuelElementsInTVS.text = Type.text switch
        {
            "1" => typeOneAndTwoTotalAmountOfFuelElements,
            "2" => typeOneAndTwoTotalAmountOfFuelElements,
            "3" => typeThreeAndFourTotalAmountOfFuelElements,
            "4" => typeThreeAndFourTotalAmountOfFuelElements,
            _ => ""
        };
    }

    // Start is called before the first frame update
    void Start()
    {  
        FrameNumber.text = "";
        Type.text = "";
        currentAmountOfFuelElementsInTVS.text = "";
        totalAmountOfFuelElementsInTVS.text = "";

        VTUKNumber.text = "";
        currentAmountOfFuelElementsInVTUK.text = "";
        totalAmountOfFuelElementsInVTUK.text = "";

        TVSFrameNumberInfoIn04Mnemo.text = "";
        TVSTypeInfoIn04Mnemo.text = "";
        EquippedFuelRodsInfoIn04Mnemo.text = "";

        VTUKNumberInfoIn02Mnemo.text = "";
    }
}
