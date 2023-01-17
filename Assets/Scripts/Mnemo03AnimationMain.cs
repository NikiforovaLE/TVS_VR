using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo03AnimationMain : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    public GameObject Mnemo04;
    private Animation animmnemo03;
    private Animation animmnemo04;

    public GameObject Shiberm03m;
    public GameObject Ramka03m;
    public GameObject M03m03m;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public Animator Ustanovkarazborkimagtvel;
    public Animator Ustanovkapozitsiitvela;

    [SerializeField] private Text magazineNumberText;
    [SerializeField] private Text fuelRodsRemovedText;
    [SerializeField] private Text lastReadFuelRodsNumberText;

    private List<string> lastReadFuelRodsNumbers;
    private List<string> fuelRodsRemoveds;
    public static string currentFuelRodNumber;

    private int countLastReadFuelRodsNumbers;
    private int countFuelRodsRemoveds;



    // Start is called before the first frame update
    void Start()
    {
        animmnemo03 = gameObject.GetComponent<Animation>();
        animmnemo04 = Mnemo04.GetComponent<Animation>();
        //animmnemo03["03 Mnemo Animation"].time = 20.0f;


        lastReadFuelRodsNumbers = new List<string> { "", "01000123", "01004023", "01008023", "01012023", "01016023" };
        fuelRodsRemoveds = new List<string> { "", "001", "040", "080", "120", "160" };

        countLastReadFuelRodsNumbers = Mnemo03Animation.countLastReadFuelRodsNumbers;
        countFuelRodsRemoveds = Mnemo03Animation.countFuelRodsRemoveds;

        lastReadFuelRodsNumberText.text = lastReadFuelRodsNumbers[countLastReadFuelRodsNumbers];
        fuelRodsRemovedText.text = fuelRodsRemoveds[countFuelRodsRemoveds];
    }

    public void AnimationMnemo03Stop()
    {
        //animmnemo03.Stop();
        Mnemo03Onn();
    }

    private void Mnemo03Onn()
    {
        Shiberm.SetActive(true);
        Ramka.SetActive(true);
        M03m.SetActive(true);
    }

    private void Mnemo03OnMain()
    {
        Mnemo03.SetActive(true);
    }


    private void Mnemo03Off()
    {
        Mnemo02.SetActive(false);
        Shiberm.SetActive(false);
        Ramka.SetActive(false);
        M03m.SetActive(false);
    }

    public void UstanovkapozitsiitvelaRun()
    {
        Ustanovkapozitsiitvela.Play("CoordinateMoving", 0, 0f);
    }

    public void UstanovkarazborkimagtvelRun()
    {
        Ustanovkarazborkimagtvel.Play("ExtractingAndLoadingTvel", 0, 0f);
        animmnemo03.Play();
    }

    public void UstanovkarazborkimagtvelStop()
    {
        Ustanovkarazborkimagtvel.enabled = false;
        //Mnemo03Off();
        Mnemo03OnMain();
        Mnemo04.SetActive(true);
        animmnemo04.Play("04 Mnemo Animation");
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }


    public void LastReadFuelRodsNumber()
    {
        countLastReadFuelRodsNumbers = countLastReadFuelRodsNumbers + 1;
        lastReadFuelRodsNumberText.text = lastReadFuelRodsNumbers[countLastReadFuelRodsNumbers];
        currentFuelRodNumber = lastReadFuelRodsNumberText.text;
    }

    public void RuelRodsRemoveds()
    {
        countFuelRodsRemoveds = countFuelRodsRemoveds + 1;
        fuelRodsRemovedText.text = (fuelRodsRemoveds[countFuelRodsRemoveds]);
    }
}
