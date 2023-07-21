using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo16Animation : MonoBehaviour
{
    [SerializeField] private Text currentBox;
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text typeOfTVS;
    [SerializeField] private Text verticalMovementLevel;
    [SerializeField] private Text boxGrippingIsClosed;

    [SerializeField] private GameObject additionalMnemo15;
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;

    public ARM2Mnemo0 ARM2Mnemo0;

    private readonly string verticalMovementLevelWhenTop = "Верхний";
    private readonly string verticalMovementLevelWhenDown = "Нижний";
    private readonly string isClosed_Yes = "Да";
    private readonly string isClosed_No = "Нет";
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

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
        typeOfTVS.text = ARM2Mnemo0.Type.text;
    }
}