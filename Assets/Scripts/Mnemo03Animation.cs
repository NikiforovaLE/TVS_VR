using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo03Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    public GameObject Mnemo03M;
    public GameObject Mnemo04;
    private Animation animmnemo03;
    private Animation animmnemo03m;
    private Animation animmnemo04;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public GameObject Magazin;

    public Animator Ustanovkarazborkimagtvel;
    public Animator Ustanovkapozitsiitvela;

    [SerializeField] private Text magazineNumberText;
    [SerializeField] private Text fuelRodsRemovedText;
    [SerializeField] private Text lastReadFuelRodsNumberText;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GeneralPanelAcions AdditionalGeneralPanelAcions;

    private List<string> lastReadFuelRodsNumbers;
    private List<string> fuelRodsRemoveds;

    public static int countLastReadFuelRodsNumbers;
    public static int countFuelRodsRemoveds;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo03 = gameObject.GetComponent<Animation>();
        animmnemo04 = Mnemo04.GetComponent<Animation>();
        animmnemo03m = Mnemo03M.GetComponent<Animation>();

        lastReadFuelRodsNumbers = new List<string> { "", "01000123", "01004023", "01008023", "01012023", "01016023" };
        fuelRodsRemoveds = new List<string> { "", "001", "040", "080", "120", "160" };
        magazineNumberText.text = "";
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
        GeneralPanelAcions.SetPanelActive(Mnemo03M);
        //Mnemo03M.SetActive(true);
        //Magazin.SetActive(true);
    }

    private void Mnemo03Off()
    {
        Mnemo02.SetActive(false);
        //Shiberm.active = false;
        //Ramka.active = false;
        //M03m.active = false;
        Mnemo03.SetActive(false);
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
        Mnemo03OnMain();
        //Mnemo03Off();
        //Mnemo02.SetActive(false);
        AdditionalGeneralPanelAcions.SetPanelActive(Mnemo04);
        //Mnemo04.SetActive(true);
        animmnemo04.Play("04 Mnemo Animation");
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }

    public void LastReadFuelRodsNumber()
    {
        countLastReadFuelRodsNumbers++;
        lastReadFuelRodsNumberText.text = lastReadFuelRodsNumbers[countLastReadFuelRodsNumbers];
    }

    public void RuelRodsRemoveds()
    {
        countFuelRodsRemoveds++;
        fuelRodsRemovedText.text = fuelRodsRemoveds[countFuelRodsRemoveds];
    }
}