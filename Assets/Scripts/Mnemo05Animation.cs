using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo05Animation : MonoBehaviour
{

    private Animation animmnemo05;
    public Animator Autooperator;
    public GameObject TVSframe;
    public GameObject TVSframeAutooperator;
    public Transform Tilter;
    public GameObject Mnemo04Add;
    public GameObject Mnemo06Add;
    public GameObject Mnemo07;
    public GameObject Mnemo05;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo05 = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
        TVSframe.active = false;
        TVSframeAutooperator.active = true;
        animmnemo05.Play();
    }

    public void AutooperatorRun()
    {
        Autooperator.Play("Third_new", 0, 0f);
    }

    public void TitlerTvsRun()
    {
        Autooperator.enabled = false;
        TVSframeAutooperator.transform.SetParent(Tilter);
        Mnemo05.active = false;
        Mnemo04Add.active = false;
        Mnemo06Add.active = true;
        Mnemo07.active = true;
    }
}
