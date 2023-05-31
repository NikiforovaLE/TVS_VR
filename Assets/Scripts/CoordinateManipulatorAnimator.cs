using UnityEngine;

public class CoordinateManipulatorAnimator : MonoBehaviour
{
    [SerializeField] private GameObject TVSForTransport;
    [SerializeField] private GameObject oldTVS;

    public void SetReadyToWashingTrue()
    {
        gameObject.GetComponent<Animator>().SetBool("readyToWashing", true);
    }

    public void SetTVSForTransportActive()
    {
        TVSForTransport.SetActive(true);
        oldTVS.SetActive(false);
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
