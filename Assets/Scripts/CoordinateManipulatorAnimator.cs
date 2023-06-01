using UnityEngine;

public class CoordinateManipulatorAnimator : MonoBehaviour
{
    [SerializeField] private GameObject TVSForTransport;
    [SerializeField] private GameObject oldTVS;

    private Animator animator;

    public void SetReadyToWashingTrue()
    {
        animator.SetBool("readyToWashing", true);
    }

    public void SetReadyToDryingTrue()
    {
        animator.SetBool("readyToDrying", true);
    }

    public void SetReadyToTightnessControlTrue()
    {
        animator.SetBool("readyToTightnessControl", true);
    }

    public void SetTVSForTransportActive()
    {
        TVSForTransport.SetActive(true);
        oldTVS.SetActive(false);
    }

    public void StopAnimation()
    {
        animator.speed = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
