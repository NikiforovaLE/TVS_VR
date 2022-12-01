using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo03Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    private Animation animmnemo03;

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
    }

    public void UstanovkarazborkimagtvelPlay()
    {
        Ustanovkarazborkimagtvel.enabled = true;
    }
}
