using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo04Animation : MonoBehaviour
{
    public GameObject Mnemo02;
    public GameObject Mnemo03;
    private Animation animmnemo04;

    public GameObject Magazin;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public Animator Ustanovkapozitsiitvela;
    public Animator Ustanovkarazborkimagtvel;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo04 = gameObject.GetComponent<Animation>();
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

}
