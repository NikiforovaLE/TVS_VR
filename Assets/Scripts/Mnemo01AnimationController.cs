using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo01AnimationController : MonoBehaviour
{
    private Animation animmnemo01;
    private Animation animmnemo02;
    private Animation animmnemo03;

    public Animator Shiber;
    public Animator LojementCarkasTvs;
    public GameObject LojementSvidetelSborkaPuchka;

    public GameObject Mnemo01;
    public GameObject Mnemo02;
    public GameObject Mnemo03;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo01 = Mnemo01.GetComponent<Animation>();
        animmnemo02 = Mnemo02.GetComponent<Animation>();
        animmnemo03 = Mnemo03.GetComponent<Animation>();
        Shiber.Play("DoorMoving", 0, 0f);
        Shiber.enabled = false;

        LojementCarkasTvs.Play("LogementArriving", 0, 0f);
        LojementCarkasTvs.enabled = false;
        animmnemo01.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShiberPlay()
    {
        Shiber.enabled = true;
    }

    public void ShiberStop()
    {
        Shiber.enabled = false;
    }

    public void LojementCarkasTvsPlay()
    {
        LojementCarkasTvs.enabled = true;
    }

    public void LojementCarkasTvsStop()
    {
        LojementCarkasTvs.enabled = false;
    }

    public void Mnemo01OffMnemo02On()
    {
        Mnemo01.active = false;
        Mnemo02.active = true;
        animmnemo02.Play();
        animmnemo03.Play();
    }
}
