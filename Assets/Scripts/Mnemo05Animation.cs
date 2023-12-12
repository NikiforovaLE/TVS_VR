using UnityEngine;

public class Mnemo05Animation : MonoBehaviour
{
    public Animator Autooperator;
    public Animator Lodgement;
    public Animator Shiber;
    public GameObject AutooperatorLodgement;
    public GameObject TVSframe;
    public GameObject TVSframeAutooperator;
    public Transform Tilter;
    public GameObject Mnemo04Add;
    public GameObject Mnemo06Add;
    public GameObject Mnemo07;
    public GameObject Mnemo05;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GeneralPanelAcions AdditionalGeneralPanelAcions;

    public void StartActions()
    {
        TVSframe.SetActive(false);
        TVSframeAutooperator.SetActive(true);
    }

    public void AutooperatorRun()
    {
        Autooperator.Play("MoveLodgementToAsembly", 0, 0f);
    }

    public void TitlerTvsRun()
    {
        Autooperator.enabled = false;
        TVSframeAutooperator.transform.SetParent(Tilter);
        AdditionalGeneralPanelAcions.SetPanelActive(Mnemo06Add);
        GeneralPanelAcions.SetPanelActive(Mnemo07);
        //Mnemo05.SetActive(false);
        //Mnemo04Add.SetActive(false);
        //Mnemo06Add.SetActive(true);
        //Mnemo07.SetActive(true);
    }

    public void StartReturningEmptyLodgementOn3DAutooperator()
    {
        Autooperator.Play("Returning Empty Lodgement");
    }

    public void StartShiberOpeningOn3d()
    {
        Shiber.Play("DoorMoving");
    }

    public void StopShiberOpeningOn3d()
    {
        Shiber.speed = 0;
    }

    public void ContinueShiberOpeningOn3d()
    {
        Shiber.speed = 1;
    }

    public void StartReturningEmptyLodgementOn3DShiber()
    {
        Lodgement.Play("Returning Empty Logement");
        AutooperatorLodgement.SetActive(false);
    }
}
