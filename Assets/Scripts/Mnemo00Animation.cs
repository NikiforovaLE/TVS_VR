using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo00Animation : MonoBehaviour
{
    [SerializeField] private Text attentionMessage;
    [SerializeField] private Text currentFuel;
    public ARM2Mnemo0 ARM2Mnemo0;
    public Animation fuelMoving;
    public Animation VTUKGetting;
    public Animation VTUKReturning;
    private Animation currentMnemoAnimation;
    private List<string> fuelNumbers;
    private int fuelCount = 0;
    private readonly string doActionsOnARM = "Необходимо выполнить действия на АРМ ввода №2";

    public Text AttentionMessage { get => attentionMessage; set => attentionMessage = value; }

    public void StartMnemoAnimation()
    {
        currentMnemoAnimation.enabled = true;
    }
    public void FillFuelNumbers()
    {
        fuelNumbers = ARM2Mnemo0.Type.ToString() switch
        {
            "1" or "2" => new List<string> { "0", "1", "79", "80", "81", "159", "160" },
            "3" or "4" => new List<string> { "0", "1", "50", "51", "52", "101", "102" },
            _ => new List<string> { }
        };
        currentFuel.text = fuelNumbers[fuelCount++];
    }

    public void GetVTUK()
    {
        currentMnemoAnimation.enabled = false;
        VTUKGetting.Play();
    }
    public void LoadFuelIntoTVS()
    {
        currentMnemoAnimation.enabled = false;
        while (fuelCount < fuelNumbers.Capacity)
        {
            fuelMoving.Play();
            if (fuelCount == 3)
            {
                AttentionMessage.text = doActionsOnARM;
                fuelCount++;
                return;
            }
            fuelCount++;
        }
        fuelMoving.enabled = false;
        currentMnemoAnimation.enabled = true;
    }

    public void ShowFuelNumber()
    {
        currentFuel.text = fuelNumbers[fuelCount];
    }

    // Start is called before the first frame update
    void Start()
    {
        attentionMessage.text = "";
        currentFuel.text = "";
        currentMnemoAnimation = gameObject.GetComponent<Animation>();
    }
}