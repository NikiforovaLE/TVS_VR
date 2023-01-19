using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo07Animation : MonoBehaviour
{

    private Animation animmnemo07;
    private Animation animmnemo06;
    public Animator Tilter;
    public GameObject Mnemo06Add;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo07 = gameObject.GetComponent<Animation>();
        animmnemo06 = Mnemo06Add.GetComponent<Animation>();
        animmnemo07.Play();
    }

    void Update()
    {
        
    }

    public void TitlerRun()
    {
        Tilter.Play("TitlerAnimation", 0, 0f);
    }

    public void TitlerStop()
    {
        animmnemo06.Play();
        Tilter.enabled = false;
    }

}
