using UnityEngine;

public class ARM2Mnemo4 : MonoBehaviour
{
    [SerializeField] private GameObject emptyLodgementOnMnemo00;

    public void Confirm()
    {
        emptyLodgementOnMnemo00.SetActive(false);
    }
}
