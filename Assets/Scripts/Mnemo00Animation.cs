using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo00Animation : MonoBehaviour
{
    [SerializeField] private Text attentionMessageOne;
    [SerializeField] private Text attentionMessageTwo;
    [SerializeField] private Text currentFuel;
    [SerializeField] private Text currentContainerNumber;
    [SerializeField] private Text currentVTUKNumber;
    [SerializeField] private Text totalFuelAmount;
    public GameObject yellowBackgroungOne;
    public GameObject yellowBackgroungTwo;
    public ARM2Mnemo0 ARM2Mnemo0;
    public ARM2Mnemo1 ARM2Mnemo1;
    public ARM2Mnemo2 ARM2Mnemo2;
    public Animator mnemo00Animator;
    private List<string> fuelNumbers;
    private int fuelCount = 0;
    private bool toBeYellowOne = true;
    private bool toBeYellowTwo = false;
    private readonly string doActionsOnARM = "Необходимо выполнить действия на АРМ ввода №2";

    public Text AttentionMessage { get => attentionMessageTwo; set => attentionMessageTwo = value; }
    public Text AttentionMessageOne { get => attentionMessageOne; set => attentionMessageOne = value; }
    public bool ToBeYellowOne { get => toBeYellowOne; set => toBeYellowOne = value; }
    public bool ToBeYellowTwo { get => toBeYellowTwo; set => toBeYellowTwo = value; }

    public void StartMnemoAnimation()
    {
        mnemo00Animator.Play("00 Mnemo Animation");
    }
    public void FillFuelNumbers()
    {
        fuelNumbers = ARM2Mnemo0.Type.ToString() switch
        {
            "1" or "2" => new List<string> { "0", "1", "79", "80", "81", "159", "160" },
            "3" or "4" => new List<string> { "0", "1", "50", "51", "52", "101", "102" },
            _ => new List<string> { "0", "1", "79", "80", "81", "159", "160" }
        };
        currentFuel.text = fuelNumbers[fuelCount++];
    }

    public void GetVTUK()
    {
        mnemo00Animator.Play("VTUKGetting");
    }
    public void LoadFuelIntoTVS()
    {
        for (int i = fuelCount; i < fuelNumbers.Count; i++)
        {
            PlayFuelMoving();
            if (fuelCount == 3)
            {
                AttentionMessage.text = doActionsOnARM;
                toBeYellowTwo = true;
                mnemo00Animator.Play("ReturnVTUK");
                return;
            }
        }
        //mnemo00Animator.Play("Mnemo00Continue");
    }

    private void PlayFuelMoving()
    {
        mnemo00Animator.Play("FuelMoving");
        new WaitForSeconds(11);
        mnemo00Animator.Update(0f);
    }

    public void ShowFuelNumber()
    {
        currentFuel.text = fuelNumbers[fuelCount++];
    }

    // Start is called before the first frame update
    void Start()
    {
        AttentionMessageOne.text = "Необходимо выполнить операции на АРМ ввода №1";
        attentionMessageTwo.text = "";
        currentFuel.text = "";
        currentContainerNumber.text = "";
        currentVTUKNumber.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        SetBackground(yellowBackgroungOne, ToBeYellowOne);
        SetBackground(yellowBackgroungTwo, ToBeYellowTwo);
        currentContainerNumber.text = ARM2Mnemo1.CurrentContainerNumber;
        currentVTUKNumber.text = ARM2Mnemo2.CurrentVTUK;
        totalFuelAmount.text = ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK;
    }

    private void SetBackground(GameObject background, bool toBeYellow)
    {
        background.SetActive(toBeYellow);
    }
}