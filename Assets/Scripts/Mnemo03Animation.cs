using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo03Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo04;
    private Animation animmnemo03;
    private Animation animmnemo04;

    public GameObject Magazin;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public Animator Ustanovkarazborkimagtvel;
    public Animator Ustanovkapozitsiitvela;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo03 = gameObject.GetComponent<Animation>();
        animmnemo04 = Mnemo04.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Magazin.active = true;
    }

    public void AnimationMnemo03Stop()
    {
        //animmnemo03.Stop();
        Mnemo03Onn();
    }

    private void Mnemo03Onn()
    {
        Mnemo02.active = false;
        Shiberm.active = true;
        Ramka.active = true;
        M03m.active = true;
    }

    private void Mnemo03Off()
    {
        Shiberm.active = false;
        Ramka.active = false;
        M03m.active = false;
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
        Mnemo03Off();
        Mnemo04.active = true;
        animmnemo04.Play();
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }
}
