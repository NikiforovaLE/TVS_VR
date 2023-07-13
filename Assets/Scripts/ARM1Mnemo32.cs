using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ARM1Mnemo32 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo1 ARM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 ARM1Mnemo2;
    [SerializeField] private ARMPanelActions ARM1PanelActions;
    [SerializeField] private Text containerNumber;
    [SerializeField] private Text messageOnARM1TopPanel;
    [SerializeField] private Text generalMessage;
    [SerializeField] private Text ARM2Message;
    [SerializeField] private Text attention;
    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;
    private string currentContainer;
    private int counter;

    public string CurrentContainer { get => currentContainer; set => currentContainer = value; }

    public void ShowContainerNumber()
    {
        Dictionary<string, string> numberOfDeffectContainersAndItsFrames = ARM1Mnemo2.NumberOfDeffectContainersAndItsFrames;
        List<string> chosenContainerNumbers = ARM1Mnemo2.DeffectContainers;
        int size = chosenContainerNumbers.Count;
        Image currentIndicator = ARM1Mnemo2.Indicators1[counter];
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        containerNumber.text = "";
        CurrentContainer = "";
        attention.text = "";
    }
}
