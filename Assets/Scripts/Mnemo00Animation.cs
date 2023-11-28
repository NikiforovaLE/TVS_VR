using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo00Animation : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo0 arm2Mnemo0;
    [SerializeField] private ARM2Mnemo1 arm2Mnemo1;
    [SerializeField] private ARM2Mnemo2 arm2Mnemo2;
    [SerializeField] private Mnemo03Animation mnemo03Animation;
    [SerializeField] private Mnemo04Animation mnemo04Animation;
    [SerializeField] private Animator attentionBlockOne;
    [SerializeField] private Animator attentionBlockTwo;

    [SerializeField] private Text attentionMessageOne;
    [SerializeField] private Text attentionMessageTwo;

    [SerializeField] private Text currentContainerNumber;
    [SerializeField] private Text currentVTUKNumber;
    [SerializeField] private Text currentFuel;
    [SerializeField] private Text currentMagazine;

    [SerializeField] private Text currentFuelAmountInTvs;
    [SerializeField] private Text totalFuelAmountInTvs;
    [SerializeField] private Text currentFuelAmountInVtuk;
    [SerializeField] private Text totalFuelAmountInVtuk;

    public GameObject yellowBackgroungOne;
    public GameObject yellowBackgroungTwo;

    public Animator mnemo00Animator;

    private List<string> fuelNumbersInTvs;
    private List<string> fuelNumbersInVtuk;

    private int fuelCount = 0;
    private int vtukGettingCount = 0;

    private readonly string needToReturnVtuk = "Необходимо вернуть ВТУК на АРМ ввода №2";
    private readonly string returnEmptyLodgementMessage = "Необходимо вернуть порожний ложемент-свидетель";
    private readonly string returnVtukMessage = "Необходимо вернуть ВТУК";

    public Text AttentionMessageOne { get => attentionMessageOne; set => attentionMessageOne = value; }
    public Text AttentionMessageTwo { get => attentionMessageTwo; set => attentionMessageTwo = value; }
    public int VtukGettingCount { get => vtukGettingCount; set => vtukGettingCount = value; }
    public Text CurrentMagazine { get => currentMagazine; set => currentMagazine = value; }

    public void FillInitialInfo()
    {
        currentFuel.text = "";
        FillFuelNumbers();
        string vtukNumber = arm2Mnemo2.CurrentVTUK;
        CurrentMagazine.text = "МАГАЗ" + vtukNumber.Substring(vtukNumber.Length - 3);
    }

    public void FillFuelNumbers()
    {
        string tvsType = arm2Mnemo0.Type.ToString();

        fuelNumbersInTvs = tvsType switch
        {
            "1" or "2" => new List<string> { "0", "1", "79", "80", "81", "159", "160" },
            "3" or "4" => new List<string> { "0", "1", "50", "51", "52", "101", "102" },
            _ => new List<string> { "0", "1", "79", "80", "81", "159", "160" }
        };

        fuelNumbersInVtuk = tvsType switch
        {
            "1" or "2" => new List<string> { "0", "1", "79", "80", "1", "79", "80" },
            "3" or "4" => new List<string> { "0", "1", "50", "51", "1", "50", "51" },
            _ => new List<string> { "0", "1", "79", "80", "1", "79", "80" }
        };

        currentFuelAmountInTvs.text = fuelNumbersInTvs[fuelCount];
        currentFuelAmountInVtuk.text = fuelNumbersInVtuk[fuelCount];
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
            StartBlinkingTwo(needToReturnVtuk);
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
    public void ShowFuelNumberInVtuk()
    {
        currentFuelAmountInVtuk.text = fuelNumbersInVtuk[++fuelCount];
    }

    public void ShowFuelNumberInTvs()
    {
        currentFuelAmountInTvs.text = fuelNumbersInTvs[fuelCount];
        mnemo00Animator.SetInteger("fuelCount", fuelCount);
    }

    public void ShowMessagesToReturnEmptyLodgementAndVtuk()
    {
        attentionMessageOne.text = returnEmptyLodgementMessage;
        attentionMessageTwo.text = returnVtukMessage;
        attentionBlockOne.enabled = true;
        attentionBlockTwo.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        AttentionMessageOne.text = "Необходимо выполнить операции на АРМ ввода №1";
        attentionMessageTwo.text = "";
        currentContainerNumber.text = "";
        currentVTUKNumber.text = "";
        currentFuel.text = "";
        CurrentMagazine.text = "";
        mnemo00Animator.SetInteger("fuelCount", 0);
        attentionBlockOne.enabled = true;
        attentionBlockTwo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentContainerNumber.text = arm2Mnemo1.CurrentContainerNumber;
        currentVTUKNumber.text = arm2Mnemo2.CurrentVTUK;
        currentFuel.text = mnemo04Animation.CurrentFuelRodNumberText.text;

        totalFuelAmountInTvs.text = arm2Mnemo0.TotalAmountOfFuelElementsInTVS.text;
        totalFuelAmountInVtuk.text = arm2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK;
    }

    public void StopBlinkingOne()
    {
        attentionBlockOne.enabled = false;
        AttentionMessageOne.text = "";
        yellowBackgroungOne.SetActive(false);
    }

    public void StartBlinkingTwo(string message)
    {
        AttentionMessageTwo.text = message;
        attentionBlockTwo.enabled = true;
    }

    public void StopBlinkingTwo()
    {
        attentionBlockTwo.enabled = false;
        AttentionMessageTwo.text = "";
        yellowBackgroungTwo.SetActive(false);
    }
}