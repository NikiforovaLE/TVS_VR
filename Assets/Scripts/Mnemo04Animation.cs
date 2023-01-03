using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo04Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    private Animation animmnemo04;
    private Animation animmnemo03;

    public GameObject Magazin;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public GameObject mnemo0404;
    public GameObject mnemo0402;
    public GameObject mnemo04051;
    public GameObject mnemo04052;

    public Animator Ustanovkapozitsiitvela;
    public Animator Ustanovkarazborkimagtvel;

    [SerializeField] private Text equippedFuelRodsText;
    [SerializeField] private Text currentFuelRodNumberText;
    [SerializeField] private Text pushPositionText;

    private int countpushPosition;
    private List<string> pushPositions;
    private List<string> currentFuelRodNumbers;


    // Start is called before the first frame update
    void Start()
    {
        animmnemo04 = gameObject.GetComponent<Animation>();
        animmnemo03 = Mnemo03.GetComponent<Animation>();
        pushPositions = new List<string> { "", "001", "040", "080", "120", "160" };
        currentFuelRodNumbers =  new List<string> { "", "01000123", "01004023", "01008023", "01012023", "01016023" };
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Mnemo03Off()
    {
        Shiberm.active = false;
        Ramka.active = false;
        M03m.active = false;
    }

    private void Mnemo03On()
    {
        Shiberm.active = true;
        Ramka.active = true;
        M03m.active = true;
    }

    private void Mnemo04Off()
    {
        //mnemo0404.active = false;
        //mnemo0402.active = false;
        //mnemo04051.active = false;
        //mnemo04052.active = false;
        //Mnemo03On();
        animmnemo03.Play("03 Mnemo Animation1");
    }

    public void UstanovkapozitsiitvelaRun()
    {
        Ustanovkapozitsiitvela.Play("CoordinateMoving", 0, 0f);
        animmnemo04.Play();
    }

    public void UstanovkapozitsiitvelaStop()
    {
        Mnemo03Off();
        Ustanovkapozitsiitvela.enabled = false;
    }

    public void UstanovkapozitsiitvelaPlay()
    {
        Ustanovkapozitsiitvela.enabled = true;
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }

    /*public void Mnemo03Play()
    {
        animmnemo03.Play("03 Mnemo Animation");
    }*/

    public void Mnemo03Stop()
    {
        animmnemo03.Stop();
    }

    public void CurrentFuelRodNumber()
    {
        countpushPosition = countpushPosition + 1;
        currentFuelRodNumberText.text = currentFuelRodNumbers[countpushPosition];
        pushPositionText.text = pushPositions[countpushPosition];
    }

    public void EquippedFuelRods()
    {
        equippedFuelRodsText.text = pushPositionText.text;
    }


}
