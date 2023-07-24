using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Mnemo0 : MonoBehaviour
{
    [SerializeField] private List<Text> readNumbers;
    [SerializeField] private ARM1Mnemo1 aRM1Mnemo1;

    public void FillReadNumbers()
    {
        List<Text> readNumbersFromArm1 = aRM1Mnemo1.ReadNumbers;
        List<string> chosenNumbersFromArm1 = aRM1Mnemo1.ChosenNumbers;
        int counter = aRM1Mnemo1.CounterOfReadNumbers;
        for (int i = 0; i < counter; i++)
        {
            readNumbersFromArm1[i].text = chosenNumbersFromArm1[i];
            readNumbers[i].text = chosenNumbersFromArm1[i];
        }
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
