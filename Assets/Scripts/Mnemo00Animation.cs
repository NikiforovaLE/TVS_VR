using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo00Animation : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private ARM2Mnemo1 ARM2Mnemo1;
    [SerializeField] private ARM2Mnemo2 ARM2Mnemo2;
    [SerializeField] private Mnemo04Animation mnemo04Animation;

    [SerializeField] private Text attentionMessageOne;
    [SerializeField] private Text attentionMessageTwo;
    [SerializeField] private Text currentFuel;
    [SerializeField] private Text currentContainerNumber;
    [SerializeField] private Text currentVTUKNumber;
    [SerializeField] private Text currentFuelAmount;
    [SerializeField] private Text totalFuelAmount;

    public GameObject yellowBackgroungOne;
    public GameObject yellowBackgroungTwo;

    public Animator mnemo00Animator;

    private List<string> fuelNumbers;
    private int fuelCount = 0;
    private int vtukGettingCount = 0;
    private bool toBeYellowOne = true;
    private bool toBeYellowTwo = false;

    private readonly string doActionsOnARM2 = "Необходимо выполнить операции на АРМ ввода №2";
    private readonly string returnEmptyLodgementMessage = "Необходимо вернуть порожний ложемент-свидетель";
    private readonly string returnVtukMessage = "Необходимо вернуть ВТУК";

    public Text AttentionMessageOne { get => attentionMessageOne; set => attentionMessageOne = value; }
    public Text AttentionMessageTwo { get => attentionMessageTwo; set => attentionMessageTwo = value; }
    public bool ToBeYellowOne { get => toBeYellowOne; set => toBeYellowOne = value; }
    public bool ToBeYellowTwo { get => toBeYellowTwo; set => toBeYellowTwo = value; }
    public int VtukGettingCount { get => vtukGettingCount; set => vtukGettingCount = value; }

    public void FillFuelNumbers()
    {
        fuelNumbers = ARM2Mnemo0.Type.ToString() switch
        {
            "1" or "2" => new List<string> { "0", "1", "79", "80", "81", "159", "160" },
            "3" or "4" => new List<string> { "0", "1", "50", "51", "52", "101", "102" },
            _ => new List<string> { "0", "1", "79", "80", "81", "159", "160" }
        };
        currentFuel.text = fuelNumbers[fuelCount];
        mnemo00Animator.SetInteger("fuelCount", fuelCount);
    }

    public void GetVTUK()
    {
        mnemo00Animator.Play("VTUKGetting");
        mnemo00Animator.SetInteger("VTUKGettingCount", ++VtukGettingCount);
    }

    //At the end of the VTUKGetting animation
    public void LoadFuelIntoTVS()
    {
        mnemo00Animator.Play("FuelMoving");
        //mnemo04Animation.Mnemo04Off();
    }

    private void CheckConditionToStopAnimation()
    {
        if (mnemo00Animator.GetInteger("fuelCount") == 3)
        {
            AttentionMessageTwo.text = doActionsOnARM2;
            toBeYellowTwo = true;
            mnemo00Animator.Play("ReturnVTUK");
        }
        else if (mnemo00Animator.GetInteger("fuelCount") == 6)
        {
            mnemo00Animator.Play("ReturnVTUK");
        }
    }

    public void StartMnemo00Continue()
    {
        if (mnemo00Animator.GetInteger("fuelCount") == 6)
        {
            mnemo00Animator.Play("Mnemo00Continue");
        }
    }

    public void ShowFuelNumber()
    {
        fuelCount++;
        currentFuelAmount.text = fuelNumbers[fuelCount];
        mnemo00Animator.SetInteger("fuelCount", fuelCount);
    }

    public void ShowMessagesToReturnEmptyLodgementAndVtuk()
    {
        toBeYellowOne = true;
        toBeYellowTwo = true;
        attentionMessageOne.text = returnEmptyLodgementMessage;
        attentionMessageTwo.text = returnVtukMessage;
    }

    // Start is called before the first frame update
    void Start()
    {
        AttentionMessageOne.text = "Необходимо выполнить операции на АРМ ввода №1";
        attentionMessageTwo.text = "";
        currentFuel.text = "";
        currentContainerNumber.text = "";
        currentVTUKNumber.text = "";
        mnemo00Animator.SetInteger("fuelCount", 0);
        mnemo00Animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetBackgroundActive(yellowBackgroungOne, ToBeYellowOne);
        SetBackgroundActive(yellowBackgroungTwo, ToBeYellowTwo);
        currentContainerNumber.text = ARM2Mnemo1.CurrentContainerNumber;
        currentVTUKNumber.text = ARM2Mnemo2.CurrentVTUK;
        totalFuelAmount.text = ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK;
    }

    private void SetBackgroundActive(GameObject background, bool toBeYellow)
    {
        background.SetActive(toBeYellow);
    }
}