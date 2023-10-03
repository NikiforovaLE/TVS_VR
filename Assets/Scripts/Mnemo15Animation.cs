using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo15Animation : MonoBehaviour
{
    [SerializeField] private Mnemo16Info mnemo16Info;

    [SerializeField] private Text currentBox;
    [SerializeField] private Text currentFrame;
    [SerializeField] private Text destinationPosition;

    public ARM2Mnemo0 aRM2Mnemo0;

    private readonly string positionIsManipulatorCran = "Кран-манипулятор";
    private readonly string positionIsCoordinateManipulator = "Координатный манипулятор";
    private readonly string positionIsBoxLidRemoving = "Снятие крышки пенала";

    public void FillInfo()
    {
        currentBox.text = mnemo16Info.CurrentBox;
        currentFrame.text = aRM2Mnemo0.FrameNumber.text;
        destinationPosition.text = positionIsManipulatorCran;
    }

    public void SetBoxLidRemoving()
    {
        destinationPosition.text = positionIsBoxLidRemoving;
    }

    public void SetCoordinateManipulatorPosition()
    {
        destinationPosition.text = positionIsCoordinateManipulator;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentBox.text = "";
        currentFrame.text = "";
    }
}