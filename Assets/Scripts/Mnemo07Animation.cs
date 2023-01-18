using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo07Animation : MonoBehaviour
{

    private Animation animmnemo07;
    public Animator Tilter;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo07 = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
        animmnemo07.Play();
    }

    public void TitlerRun()
    {
        Tilter.Play("TitlerAnimation", 0, 0f);
    }

    public void TitlerStop()
    {
        Tilter.enabled = false;
    }

}
