using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo07Animation : MonoBehaviour
{

    private Animation animmnemo07;
    private Animation animmnemo06;
    public Animator Tilter;
    public GameObject Mnemo06Add;

    private List<string> stateHeadLatches;
    private List<string> capturesFixing;
    private List<string> screwedNuts;
    private List<string> flared;

    private int countstateHeadLatches = 0;
    private int countcapturesFixing = 0;
    private int countscrewedNuts = 0;
    private int countsflared = 0;

    [SerializeField] private Text stateHeadLatchesText;
    [SerializeField] private Text capturesFixingText;
    [SerializeField] private Text screwedNutsText;
    [SerializeField] private Text flaredText;
    [SerializeField] public GameObject Mnemo08;
    [SerializeField] public GameObject Mnemo09;
    [SerializeField] public GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] public GeneralPanelAcions AdditionlGeneralPanelAcions;
    // Start is called before the first frame update
    void Start()
    {
        animmnemo07 = gameObject.GetComponent<Animation>();
        animmnemo06 = Mnemo06Add.GetComponent<Animation>();
        //animmnemo07.Play();

        stateHeadLatches = new List<string> { "Не поджата", "Поджата" };
        capturesFixing = new List<string> { "Открыты", "Закрыты" };
        screwedNuts = new List<string> { "0", "1", "2", "3", "4", "5", "6" };
        flared = new List<string> { "0", "1","2", "3", "4", "5", "6" };

        stateHeadLatchesText.text = stateHeadLatches[countstateHeadLatches];
        capturesFixingText.text = capturesFixing[countcapturesFixing + 1];
        screwedNutsText.text = screwedNuts[countscrewedNuts];
        flaredText.text = flared[countsflared];
    }

    public void TitlerRun()
    {
        Tilter.Play("TitlerAnimation", 0, 0f);
    }

    public void TitlerStop()
    {
        //animmnemo06.Play();
        Tilter.enabled = false;
    }

    public void stateHeadLatchesPreloaded()
    {
        countstateHeadLatches++;
        stateHeadLatchesText.text = stateHeadLatches[countstateHeadLatches];
    }

    public void screwedNutsAdd()
    {
        countscrewedNuts++;
        screwedNutsText.text = screwedNuts[countscrewedNuts];
    }

    public void flaredAdd()
    {
        countsflared++;
        flaredText.text = flared[countsflared];
    }

    public void Disable07MnemoShow09Mnemo()
    {
        //Set mnemo08 active on MainPanel
        GeneralPanelAcions.SetPanelActive(Mnemo09);
    }
}
