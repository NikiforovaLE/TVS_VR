using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation3DControl : MonoBehaviour
{
    private bool flag = false;
    public Animator Shiber;
    public Animator LojementCarkasTvs;
    public GameObject LojementSvidetelSborkaPuchka;

    public Animator UzelStikovki;
    public Animator Magazin;
    public Animator RazborkaMagazina;

    public Animator PozicionirovTvela;
    public Animator Autooperator;
    public Animator Kantovatel;
    public Animator Sborka;
    public Animator CoordinatManipulator;

    public GameObject LojementSvidetelAutooperator;
    public GameObject HeadTvs;
    public GameObject Tvs;

    public Transform KantovatelOb;
    public Transform TVS;
    public Transform CoodinRichag;

    public float RunTime;
    public int counttvel;

    public bool StateAnimation;

    public bool Flag { get => flag; set => flag = value; }

    void Start()
    {

    }
    public void ShiberFun()
    {
        LojementCarkasTvs.enabled = false;
        Shiber.Play("DoorMoving", 0, 0f);
        Shiber.enabled = true;
    }

    public void LojementCarkasTvsFun()
    {
        Shiber.enabled = false;
        LojementCarkasTvs.Play("LogementArriving", 0, 0f);
        LojementCarkasTvs.enabled = true;
    }

    public void UzelStikovkiFun()
    {
        Shiber.enabled = false;
        UzelStikovki.Play("DoorOpening", 0, 0f);
        UzelStikovki.enabled = true;
    }

    public void MagazinFun()
    {
        //Magazin.SetFloat("Speed", 1);
        Magazin.Play("MagazinArriving", 0, 0);
        Magazin.enabled = true;
    }

    public void MagazinFun1()
    {
        //Magazin.SetFloat("Speed", -1);
        Magazin.speed = -1;
        Magazin.Play("MagazinArriving", -1, 0);
        Magazin.enabled = true;
    }

    public void RazborkaMagazinaFun()
    {
        RazborkaMagazina.Play("ExtractingAndLoadingTvel", 0, 0f);
        RazborkaMagazina.enabled = true;
    }

    public void PozicionirovTvelaFunRun()
    {
        PozicionirovTvela.Play("CoordinateMoving", 0, 0f);
        PozicionirovTvela.enabled = true;
    }

    public void AutooperatorFun()
    {
        Autooperator.Play("Third_new", 0, 0f);
        Autooperator.enabled = true;
    }

    public void KantovatelFun()
    {
        Kantovatel.Play("TitlerAnimation", 0, 0f);
        Kantovatel.enabled = true;
    }

    public void SborkaFun()
    {
        Sborka.Play("Armature_Action_Event", 0, 0f);
        Sborka.enabled = true;
    }

    public void CoordinatManipulatorFun()
    {
        CoordinatManipulator.Play("GrabTVSToBufer", 0, 0f);
        Sborka.enabled = false;
    }

    public void RazborkaMagazinaFunStop()
    {
        RazborkaMagazina.enabled = false;
    }

    public void PozicionirovTvelaFunStop()
    {
        PozicionirovTvela.enabled = false;
    }

    //// Update is called once per frame
    void Update()
    {
        if (flag)
        {
            RunTime += Time.deltaTime;

            if (RunTime > 1 && RunTime < 1.1)
            {
                ShiberFun();
            }

            if (RunTime > 4.5 && RunTime < 4.6)
                LojementCarkasTvsFun();

            if (RunTime > 9.5 && RunTime < 9.6)
            {
                Shiber.enabled = true;
                LojementCarkasTvs.enabled = false;
            }

            if (RunTime > 13 && RunTime < 13.1)
            {
                LojementSvidetelSborkaPuchka.SetActive(false);
                LojementSvidetelAutooperator.SetActive(true);
                UzelStikovkiFun();
            }

            if (RunTime > 15.5 && RunTime < 15.8)
            {
                UzelStikovki.enabled = false;
                MagazinFun();
            }

            if (RunTime > 20.5 && RunTime < 20.6)
                UzelStikovki.enabled = true;

            if (RunTime > 25.5 && RunTime < 25.6)
                RazborkaMagazinaFun();

            if (RunTime > 33.92 && RunTime < 33.93)
                PozicionirovTvelaFunRun();

            if (RunTime > 39.63 && RunTime < 39.64)
                RazborkaMagazina.enabled = false;

            if (RunTime > 50.25 && RunTime < 50.26)
                RazborkaMagazina.enabled = true;

            if (RunTime > 60.15 && RunTime < 60.2)
            {
                AutooperatorFun();
                //RunTime = 24;
                //counttvel++;
            }

            if (RunTime > 90.15 && RunTime < 90.2)
            {
                Autooperator.enabled = false;
                LojementSvidetelAutooperator.transform.SetParent(KantovatelOb);
                KantovatelFun();
                //RunTime = 24;
                //counttvel++;
            }

            if (RunTime > 95.1 && RunTime < 95.2)
            {
                Kantovatel.enabled = false;
                SborkaFun();
            }

            if (RunTime > 107.1 && RunTime < 107.2)
            {
                HeadTvs.transform.SetParent(TVS);
            }

            if (RunTime > 135.1 && RunTime < 135.2)
            {
                Sborka.enabled = false;
                CoordinatManipulatorFun();
            }

            if (RunTime > 146.1 && RunTime < 146.2)
            {
                Sborka.enabled = false;
                Tvs.transform.SetParent(CoodinRichag);
            }

            if (RunTime > 157.1 && RunTime < 157.2)
            {
                Sborka.enabled = false;
                Tvs.transform.SetParent(null);
            }
        }
    }
}
