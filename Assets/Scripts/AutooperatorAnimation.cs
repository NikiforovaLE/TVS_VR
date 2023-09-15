using UnityEngine;

public class AutooperatorAnimation : MonoBehaviour
{
    [SerializeField] private GameObject lodgement;

    public void MakeLodgementInvisible()
    {
        lodgement.SetActive(false);
    }
}
