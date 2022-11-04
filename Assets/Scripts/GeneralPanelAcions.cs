using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPanelAcions : MonoBehaviour
{
    [SerializeField] private GameObject mnemoOne;
    [SerializeField] private GameObject mnemoTwo;
    [SerializeField] private GameObject mnemoThree;
    [SerializeField] private GameObject mnemoFour;
    [SerializeField] private GameObject _button05Mneomo;
    [SerializeField] private GameObject _button06Mneomo;
    [SerializeField] private GameObject _button07Mneomo;
    [SerializeField] private GameObject _button08Mneomo;
    [SerializeField] private GameObject _button09Mneomo;
    [SerializeField] private GameObject _button10Mneomo;
    [SerializeField] private GameObject _button11Mneomo;
    [SerializeField] private GameObject _button12Mneomo;
    [SerializeField] private GameObject _button13Mneomo;
    [SerializeField] private GameObject _button14Mneomo;
    [SerializeField] private GameObject _button15Mneomo;
    [SerializeField] private GameObject _button16Mneomo;
    [SerializeField] private GameObject _button17Mneomo;

    private List<GameObject> mnemos;

    public void SetButonPanelActive(GameObject buttonMnemo)
    {
        int panelIndex = mnemos.IndexOf(buttonMnemo);
        for (int i = 0; i < mnemos.Count; i++)
        {
            if (i != panelIndex)
            {
                mnemos[i].SetActive(false);
            }
        }
        mnemos[panelIndex].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemos = new List<GameObject>() {
        mnemoOne, mnemoTwo, mnemoThree, mnemoFour, _button05Mneomo, _button06Mneomo,
        _button07Mneomo, _button08Mneomo, _button09Mneomo, _button10Mneomo, _button11Mneomo, _button12Mneomo,
        _button13Mneomo, _button14Mneomo, _button15Mneomo, _button16Mneomo, _button17Mneomo};
        for (int i = 0; i < mnemos.Count; i++)
        {
            mnemos[i].SetActive(false);
        }
    }
}
