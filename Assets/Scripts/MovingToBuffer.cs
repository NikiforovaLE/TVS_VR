using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingToBuffer : MonoBehaviour
{
    [SerializeField] GameObject mnemo08;

    public void MoveToBuffer()
    {
        Animator mnemo08Animator = mnemo08.GetComponent<Animator>();
        while(mnemo08Animator.isActiveAndEnabled)
        if(mnemo08Animator.GetCurrentAnimatorStateInfo(0).IsName("08 Mnemo Animation Washing"))
        {
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
