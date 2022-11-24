using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo01AnimationController : MonoBehaviour
{
    private Animation anim;
    public float RunTime;

    public Animator Shiber;
    public Animator LojementCarkasTvs;
    public GameObject LojementSvidetelSborkaPuchka;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        Shiber.Play("DoorMoving", 0, 0f);
        Shiber.enabled = false;

        LojementCarkasTvs.Play("LogementArriving", 0, 0f);
        LojementCarkasTvs.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        RunTime += Time.deltaTime;

        if (RunTime > 3 && RunTime < 5.1)
            anim.Play();
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
}
