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

}
