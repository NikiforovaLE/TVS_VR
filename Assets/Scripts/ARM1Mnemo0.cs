using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo0 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo1 arm1Mnemo1;
    [SerializeField] private ARMPanelActions armPanelActions;
    [SerializeField] private ARM1Mnemo2 arm1Mnemo2;

    [SerializeField] private Text arm1Message;
    [SerializeField] private Image arm1MessageBackground;

    private readonly Color yellowBackground = new(255f, 155f, 0f, 255f);
    public void FillReadNumbers()
    {
        List<string> chosenNumbersFromArm1 = arm1Mnemo1.ChosenNumbers;
        List<Text> readNumbersFromArm1 = arm1Mnemo1.ReadNumbers;
        List<Image> indicators = arm1Mnemo2.Indicators1;
        Dictionary<string, bool> resultOfControl = arm1Mnemo2.ResultOfControl;
        string currentContainer;

        int counter = arm1Mnemo1.CounterOfReadNumbers;
        for (int i = 0; i < counter; i++)
        {
            currentContainer = chosenNumbersFromArm1[i];
            readNumbersFromArm1[i].text = currentContainer;
            if (resultOfControl.ContainsKey(currentContainer))
            {
                indicators[i].color = resultOfControl[currentContainer] ? Color.red : Color.green;
            }
            else
            {
                indicators[i].color = Color.gray;
            }

        }
        FillRemainRows(readNumbersFromArm1, counter, indicators);
    }

    private void FillRemainRows(List<Text> readNumbersFromArm1, int counter, List<Image> indicators)
    {
        for (int i = counter; i < readNumbersFromArm1.Capacity; i++)
        {
            readNumbersFromArm1[i].text = "";
            indicators[i].color = Color.gray;
        }
        armPanelActions.ShowMnemoPanel(gameObject);
    }

    public void ShowMessageOnArmlMessagePanel(string message)
    {
        arm1Message.text = message;
        arm1MessageBackground.color = yellowBackground;
    }
}
