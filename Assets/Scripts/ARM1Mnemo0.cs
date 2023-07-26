using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo0 : MonoBehaviour
{
    [SerializeField] private ARM1Mnemo1 aRM1Mnemo1;
    [SerializeField] private ARMPanelActions aRMPanelActions;
    [SerializeField] private ARM1Mnemo2 aRM1Mnemo2;

    public void FillReadNumbers()
    {
        List<string> chosenNumbersFromArm1 = aRM1Mnemo1.ChosenNumbers;
        List<Text> readNumbersFromArm1 = aRM1Mnemo1.ReadNumbers;
        List<Image> indicators = aRM1Mnemo2.Indicators1;
        Dictionary<string, bool> resultOfControl = aRM1Mnemo2.ResultOfControl;
        string currentContainer;

        int counter = aRM1Mnemo1.CounterOfReadNumbers;
        for (int i = 0; i < counter; i++)
        {
            currentContainer = chosenNumbersFromArm1[i];
            readNumbersFromArm1[i].text = currentContainer;
            if (resultOfControl.ContainsKey(currentContainer))
            {
                indicators[i].color = resultOfControl[currentContainer] ? Color.red : Color.green;
            } else
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
        aRMPanelActions.ShowMnemoPanel(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
