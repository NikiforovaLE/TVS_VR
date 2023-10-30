using UnityEngine;

public class Mnemo15Animation : MonoBehaviour
{
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;
    [SerializeField] private GameObject additionalMnemo16;

    public void ShowAndPlay16Mnemo()
    {
        additionalGeneralPanelAcions.SetPanelActive(additionalMnemo16);
        additionalMnemo16.GetComponent<Animator>().Play("16 Mnemo Animation End");
    }
}
