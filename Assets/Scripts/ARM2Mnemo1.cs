using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo1 : MonoBehaviour
{
    [SerializeField] private ARMPanelActions ARM2PanelActions;
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARM1Mnemo31 ARM1Mnemo31;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private Text outputContainerNumber;
    [SerializeField] private Text outputFrameNumber;
    [SerializeField] private Text frameNumberOnMnemo0;
    [SerializeField] private Text typeOnMnemo0;
    [SerializeField] private Text message;
    [SerializeField] private GameObject mainMnemoARM2;

    private string messageAfterConfirm = "Необходимо получить ВТУК";
    private string currentFrame;
    //private int clickCounter;

    public string CurrentFrame { get => currentFrame; set => currentFrame = value; }

    public void ShowContainerAndTVSNumbers()
    {
        string currentCont = ARM1Mnemo31.CurrentContainer;
        Dictionary<string, string> containerAndFrameNumbers = ARM1Mnemo2.NumberOfContainersAndFrames;
        outputContainerNumber.text = currentCont;
        outputFrameNumber.text = containerAndFrameNumbers[currentCont];
    }

    public void ConfirmChoice()
    {
        currentFrame = outputFrameNumber.text;
        ARM2Mnemo0.ShowTVSInfo();
        ARM2PanelActions.ShowMnemoPanel(mainMnemoARM2);
        message.text = messageAfterConfirm;


    }

    // Start is called before the first frame update
    void Start()
    {
        outputContainerNumber.text = "";
        outputFrameNumber.text = "";
        frameNumberOnMnemo0.text = "";
        currentFrame = "";
        message.text = "";
    }
}
