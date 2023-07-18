using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo14Animation : MonoBehaviour
{
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text currentBox;
    [SerializeField] private Animator transferTruckAnimator;
    [SerializeField] private Animator manipulatorCranAnimator;
    [SerializeField] private Animator coordinateManipulatorAnimator;
    public ARM2Mnemo0 ARM2Mnemo0;

    private int counter = 1;
    private Animator currentAnimator;
    private readonly string boxNumber = "BOX";

    // Start is called before the first frame update
    void Start()
    {
        currentTVS.text = "";
        currentAnimator = gameObject.GetComponent<Animator>();
        currentBox.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
    }

    public void MakeAnimatorEnableFalse()
    {
        currentAnimator.enabled = false;
    }

    public void Start3DAnimation()
    {
        //manipulatorCranAnimator.Play("PenalManipulatorMoving");
        transferTruckAnimator.Play("TruckMoving");
        currentBox.text = boxNumber + counter++;
    }

    public void ContinueCoordinateManipulatorAnimation()
    {
        coordinateManipulatorAnimator.speed = 1;
        transferTruckAnimator.speed = 0;
    }

    public void ContinueTransferTruckAnimation()
    {
        transferTruckAnimator.speed = 1;
    }
}
