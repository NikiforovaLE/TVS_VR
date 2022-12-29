using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo03Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    public GameObject Mnemo03M;
    public GameObject Mnemo04;
    private Animation animmnemo03;
    private Animation animmnemo03m;
    private Animation animmnemo04;

    public GameObject Shiberm03m;
    public GameObject Ramka03m;
    public GameObject M03m03m;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public GameObject Magazin;

    public Animator Ustanovkarazborkimagtvel;
    public Animator Ustanovkapozitsiitvela;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo03 = gameObject.GetComponent<Animation>();
        animmnemo04 = Mnemo04.GetComponent<Animation>();
        animmnemo03m = Mnemo03M.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationMnemo03Stop()
    {
        //animmnemo03.Stop();
        Mnemo03Onn();
    }

    private void Mnemo03Onn()
    {
        Shiberm.active = true;
        Ramka.active = true;
        M03m.active = true;
    }

    private void Mnemo03OnMain()
    {
        Mnemo03M.active = true;
        Magazin.active = true;
    }


    private void Mnemo03Off()
    {
        Mnemo02.active = false;
        //Shiberm.active = false;
        //Ramka.active = false;
        //M03m.active = false;
        Mnemo03.active = false;
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
        Mnemo04.active = true;
        Mnemo03Off();
        animmnemo04.Play("04 Mnemo Animation");
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }
}
