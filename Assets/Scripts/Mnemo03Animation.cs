using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo03Animation : MonoBehaviour
{
    public GameObject Mnemo03;
    private Animation animmnemo03;

    public GameObject Magazin;

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
        animmnemo03.Stop();
        Mnemo03.GetComponent<Renderer>().material.color = new Color(255, 255, 255, 0.5f);

    }
}
