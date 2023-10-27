using UnityEngine;

public class ManipulatorCranAnimator : MonoBehaviour
{
    [SerializeField] private GameObject transportTruckBox;
    [SerializeField] private GameObject transportTruckBoxLid;
    [SerializeField] private GameObject manipulatorCranBox;
    private Animator currentAnimator;

    public void StopAnimation()
    {
        currentAnimator.speed = 0;
    }

    public void MakeTransportTruckBoxVisibleManipulatorCranBoxInvisible()
    {
        transportTruckBoxLid.SetActive(true);
        transportTruckBox.SetActive(true);
        manipulatorCranBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }
}
