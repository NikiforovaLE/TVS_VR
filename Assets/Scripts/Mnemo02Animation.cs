using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo02Animation : MonoBehaviour
{
    public Animator UzelStikovki;

    public Animator RolgantVtuk;

    void Start()
    {
        UzelStikovki.Play("DoorOpening", 0, 0f);
        UzelStikovki.enabled = false;

        RolgantVtuk.Play("MagazinArriving", 0, 0f);
        RolgantVtuk.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UzelStikovkiPlay()
    {
        UzelStikovki.enabled = true;
        UzelStikovki.GetComponent<AudioSource>().Play();
    }

    public void RolgantVtukPlay()
    {
        RolgantVtuk.enabled = true;
    }

    public void UzelStikovkiStop()
    {
        UzelStikovki.enabled = false;
    }

    public void RolgantVtukStop()
    {
        RolgantVtuk.enabled = false;
    }
}
