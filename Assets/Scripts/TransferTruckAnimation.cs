using UnityEngine;

public class TransferTruckAnimation : MonoBehaviour
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
}
