using UnityEngine;

public class KantovatelAnimation : MonoBehaviour
{
    [SerializeField] private GameObject autooperatorLodgement;
    public void SetLodgementOfAutooperatorInvisible()
    {
        autooperatorLodgement.SetActive(false);
    }
}
