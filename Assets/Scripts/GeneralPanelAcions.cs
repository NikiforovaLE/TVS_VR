using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPanelAcions : MonoBehaviour
{
    [SerializeField] private GameObject _button01Mneomo;
    [SerializeField] private GameObject _button02Mneomo;
    [SerializeField] private GameObject _button03Mneomo;
    [SerializeField] private GameObject _button04Mneomo;
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

    private List<GameObject> buttonsMnemos;
   
    public void SetButonPanelActive(GameObject buttonMnemo)
    {
        int panelIndex = buttonsMnemos.IndexOf(buttonMnemo);
        for (int i = 0; i < buttonsMnemos.Count; i++)
        {
            if (i != panelIndex)
            {
                buttonsMnemos[i].SetActive(false);
            }
        }
        buttonsMnemos[panelIndex].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        buttonsMnemos = new List<GameObject>() {
        _button01Mneomo, _button02Mneomo, _button03Mneomo, _button04Mneomo, _button05Mneomo, _button06Mneomo,
        _button07Mneomo, _button08Mneomo, _button09Mneomo, _button10Mneomo, _button11Mneomo, _button12Mneomo,
        _button13Mneomo, _button14Mneomo, _button15Mneomo, _button16Mneomo, _button17Mneomo};
        for (int i = 0; i < buttonsMnemos.Count; i++)
        {
            buttonsMnemos[i].SetActive(false);
        }
    }
}
