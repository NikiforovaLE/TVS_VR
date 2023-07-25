using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo32 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo0 aRM1Mnemo0;
    [SerializeField] private ARM1Mnemo1 aRM1Mnemo1;
    [SerializeField] private ARM1Mnemo2 aRM1Mnemo2;
    [SerializeField] private ARMPanelActions ARM1PanelActions;
    [SerializeField] private Text deffectContainerNumber;
    [SerializeField] private Text attention;
    [SerializeField] private Text frameNumberOn17MnemoText;
    [SerializeField] private Text typeOfDeffectTvsOn17MnemoText;
    [SerializeField] private GameObject mainARM1Mnemo;
    [SerializeField] private GameObject mnemo17;
    [SerializeField] private GeneralPanelAcions generalPanelAcions;
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;
    private int counter;
    private string currentDeffectContainer;
    private readonly string warningMessage = "Сначала нужно считать номер контейнера!";

    public string CurrentDeffectContainer { get => currentDeffectContainer; set => currentDeffectContainer = value; }

    public void ShowContainerNumber()
    {
        List<string> deffectContainerNumbers = aRM1Mnemo2.DeffectContainers;
        int size = deffectContainerNumbers.Count;
        if (counter == size - 1)
        {
            deffectContainerNumber.text = deffectContainerNumbers[counter];
            counter = 0;
        }
        else if (counter < size)
        {
            deffectContainerNumber.text = deffectContainerNumbers[counter++];
        }
    }

    public void ConfirmChoice()
    {
        if (deffectContainerNumber.text.Equals(""))
        {
            attention.color = Color.red;
            attention.text = warningMessage;
        }
        else
        {
            attention.text = "";
            CurrentDeffectContainer = deffectContainerNumber.text;

            //correct info on ARM1 Mnemo2
            List<string> deffectContainerNumbers = aRM1Mnemo2.DeffectContainers;
            deffectContainerNumbers.Remove(CurrentDeffectContainer);

            int indexOfIndicator = aRM1Mnemo1.ChosenNumbers.IndexOf(CurrentDeffectContainer);
            aRM1Mnemo1.ChosenNumbers.RemoveAt(indexOfIndicator);
            aRM1Mnemo1.CounterOfReadNumbers--;

            List<Image> Indicators = aRM1Mnemo2.Indicators1;
            Indicators.RemoveAt(indexOfIndicator);

            // actions on ARM1Mnemo0
            aRM1Mnemo0.FillReadNumbers();
            ARM1PanelActions.ShowMnemoPanel(mainARM1Mnemo);
            
            // actions on 17.Mnemo on MainPanel
            Dictionary<string, List<string>> deffectContainerNumbersAndListOfItsFramesAndTypes = aRM1Mnemo2.DeffectContainerNumbersAndListOfItsFramesAndTypes;
            frameNumberOn17MnemoText.text = deffectContainerNumbersAndListOfItsFramesAndTypes[CurrentDeffectContainer][0];
            typeOfDeffectTvsOn17MnemoText.text = deffectContainerNumbersAndListOfItsFramesAndTypes[CurrentDeffectContainer][1];
            additionalGeneralPanelAcions.SetPanelActive(mnemo17);
        }
    }

    //private void Show17MnemoOnMainPanel()
    //{
    //    generalPanelAcions.SetPanelActive(mnemo17);
    //}

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        deffectContainerNumber.text = "";
        CurrentDeffectContainer = "";
        attention.text = "";
    }
}
