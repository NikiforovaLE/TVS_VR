using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo06Animation : MonoBehaviour
{
    private Animation animmnemo06;
    public Animator Manipulator;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo06 = gameObject.GetComponent<Animation>();
    }

    void Update()
    {
    }

    public void ManipulatorRun()
    {
        Manipulator.Play("Armature_Action_Event", 0, 0f);
    }

    public void ManipulatorStop()
    {
        animmnemo06.Stop();
        Manipulator.enabled = false;
    }
}
