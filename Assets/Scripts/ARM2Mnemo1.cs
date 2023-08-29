using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo1 : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnArm2;

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
    [SerializeField] private Text attentionMessage;
    [SerializeField] private GameObject mainMnemoARM2;

    private readonly string messageAfterConfirm = "Необходимо получить ВТУК";
    private readonly string attentionMessageAboutTheAbsenceOfContainer = "Необходимо считать номер контейнера";
    private readonly string attentionMessageAboutTheAbsenceOfFrame = "Необходимо считать номер каркаса ТВС";
    private string currentFrame;
    private string currentContainerNumber;

    // messages on ARM2 MessageArea
    private readonly string container = "Контейнер ";
    private readonly string withFrame = " с каркасом ТВС  ";
    private readonly string isRecieved = " получен на участке подачи комплектующих";
    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
    public string CurrentFrame { get => currentFrame; set => currentFrame = value; }
    public string CurrentContainerNumber { get => currentContainerNumber; set => currentContainerNumber = value; }

    public void ShowContainerAndTVSNumbers()
    {
        string currentCont = ARM1Mnemo31.CurrentContainer;
        Dictionary<string, string> containerAndFrameNumbers = ARM1Mnemo2.NumberOfContainersAndFrames;
        outputContainerNumber.text = currentCont;
        outputFrameNumber.text = containerAndFrameNumbers[currentCont];
    }

    public void ConfirmChoice()
    {
        string containerNumber = outputContainerNumber.text;
        string frameNumber = outputFrameNumber.text;
        if (containerNumber.Equals("") || frameNumber.Equals(""))
        {
            attentionMessage.color = Color.red;
            attentionMessage.text = containerNumber.Equals("") ? attentionMessageAboutTheAbsenceOfContainer : attentionMessageAboutTheAbsenceOfFrame;
        }
        else
        {
            attentionMessage.text = "";
            currentFrame = frameNumber;
            CurrentContainerNumber = containerNumber;
            ARM2Mnemo0.ShowTVSInfo();
            message.text = messageAfterConfirm;
            messageInfoOnArm2.FillInfo(container + CurrentContainerNumber + withFrame + currentFrame + isRecieved, messageSourceIsOperator, positiveStatus);
            ARM2PanelActions.ShowMnemoPanel(mainMnemoARM2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        outputContainerNumber.text = "";
        outputFrameNumber.text = "";
        frameNumberOnMnemo0.text = "";
        currentFrame = "";
        message.text = "";
        attentionMessage.text = "";
    }
}
