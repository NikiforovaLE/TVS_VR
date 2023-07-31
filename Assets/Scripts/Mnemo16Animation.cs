using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo16Animation : MonoBehaviour
{
    [SerializeField] private Text currentBoxText;
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text typeOfTVS;
    [SerializeField] private Text verticalMovementLevel;
    [SerializeField] private Text boxGrippingIsClosed;

    [SerializeField] private GameObject additionalMnemo15;
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;

    public ARM2Mnemo0 ARM2Mnemo0;

    private int boxCounter = 0;
    private string currentBox;
    private List<string> boxNumbers = new List<string> { "�����001", "�����002", "�����003", "�����004", "�����005" };

    private readonly string verticalMovementLevelWhenTop = "�������";
    private readonly string verticalMovementLevelWhenDown = "������";
    private readonly string isClosed_Yes = "��";
    private readonly string isClosed_No = "���";

    public string CurrentBox { get => currentBox; set => currentBox = value; }

    public void FillInfo()
    {
        if (boxCounter >= boxNumbers.Capacity && boxCounter < 9)
        {
            boxNumbers.Add("�����00" + (boxCounter + 1));
        }
        else if (boxCounter >= 9)
        {
            boxNumbers.Add("�����0" + (boxCounter + 1));
        }
        currentBoxText.text = boxNumbers[boxCounter++];
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
        typeOfTVS.text = ARM2Mnemo0.Type.text;
        CurrentBox = currentBoxText.text;
    }

    public void MakeVerticalMovementLevelTop()
    {
        verticalMovementLevel.text = verticalMovementLevelWhenTop;
    }

    public void MakeVerticalMovementLevelDown()
    {
        verticalMovementLevel.text = verticalMovementLevelWhenDown;
    }

    public void MakeBoxGrippingIsClosed()
    {
        boxGrippingIsClosed.text = isClosed_Yes;
    }

    public void MakeBoxGrippingIsOpened()
    {
        boxGrippingIsClosed.text = isClosed_No;
    }

    public void Show15MnemoOnAdditionalPanel()
    {
        additionalGeneralPanelAcions.SetPanelActive(additionalMnemo15);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTVS.text = "";
        typeOfTVS.text = "";
        verticalMovementLevel.text = verticalMovementLevelWhenTop;
        boxGrippingIsClosed.text = isClosed_No;
    }
}