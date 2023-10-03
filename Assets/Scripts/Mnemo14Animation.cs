using UnityEngine;

public class Mnemo14Animation : MonoBehaviour
{
    [SerializeField] private Animator transferTruckAnimator;
    [SerializeField] private Animator coordinateManipulatorAnimator;

    private Animator currentAnimator;

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    public void MakeAnimatorEnableFalse()
    {
        currentAnimator.enabled = false;
    }

    public void Start3DAnimation()
    {
        transferTruckAnimator.Play("TruckMoving");
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
