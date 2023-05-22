using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo00AnimationStarter : MonoBehaviour
{
    [SerializeField] private GameObject mnemo01;
    [SerializeField] private GameObject mnemo05;
    [SerializeField] private GameObject mnemo07;
    [SerializeField] private GameObject mnemo08;

    [SerializeField] private GameObject additionalMnemo06;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GeneralPanelAcions AdditionalGeneralPanelAcions;

    [SerializeField] private Mnemo01AnimationController mnemo01AnimationController;
    public void Start01MnemoAnimation()
    {
        GeneralPanelAcions.SetPanelActive(mnemo01);
        mnemo01.GetComponent<Animation>().Play();
    }

    public void Start06MnemoAnimation()
    {
        AdditionalGeneralPanelAcions.SetPanelActive(additionalMnemo06);
        additionalMnemo06.GetComponent<Animation>().Play();
    }

    public void Start07MnemoAnimation()
    {
        GeneralPanelAcions.SetPanelActive(mnemo07);
        mnemo07.GetComponent<Animation>().Play();
    }

    public void Start08MnemoAnimation()
    {
        AdditionalGeneralPanelAcions.SetPanelActive(mnemo08);
        mnemo08.GetComponent<Animator>().Play("08 Mnemo Animation");
    }

    public void Start02And03MnemoAnimation()
    {
        mnemo01AnimationController.Mnemo01OffMnemo02Andnemo03On();
    }

    public void Start05MnemoAnimation()
    {
        GeneralPanelAcions.SetPanelActive(mnemo05);
        mnemo05.GetComponent<Animation>().Play();
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
