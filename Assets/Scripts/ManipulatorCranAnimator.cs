using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatorCranAnimator : MonoBehaviour
{
    private Animator currentAnimator;
    public void StopAnimation()
    {
        currentAnimator.speed = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
