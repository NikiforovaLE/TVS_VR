using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralPanelAcions : MonoBehaviour
{
    [SerializeField] private GameObject mnemoZero;
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

    [SerializeField] private Image plugOfZeroImage;
    [SerializeField] private Image mnemoOneButtonImage;
    [SerializeField] private Image mnemoTwoButtonImage;
    [SerializeField] private Image mnemoThreeButtonImage;
    [SerializeField] private Image mnemoFourButtonImage;
    [SerializeField] private Image _button05MneomoImage;
    [SerializeField] private Image _button06MneomoImage;
    [SerializeField] private Image _button07MneomoImage;
    [SerializeField] private Image _button08MneomoImage;
    [SerializeField] private Image _button09MneomoImage;
    [SerializeField] private Image _button10MneomoImage;
    [SerializeField] private Image _button11MneomoImage;
    [SerializeField] private Image _button12MneomoImage;
    [SerializeField] private Image _button13MneomoImage;
    [SerializeField] private Image _button14MneomoImage;
    [SerializeField] private Image _button15MneomoImage;
    [SerializeField] private Image _button16MneomoImage;
    [SerializeField] private Image _button17MneomoImage;

    private List<GameObject> mnemos;
    private List<Image> imagesOfMnemoButtons;

    private Color buttonColorAfterClicking = new(200f / 255f, 200f / 255f, 200f / 255f);
    public void SetPanelActive(GameObject mnemo)
    {
        int mnemoIndex = mnemos.IndexOf(mnemo);
        MakePanelActiveByIndex(mnemoIndex);
        MakeButtonGray(mnemoIndex);
    }

    private void MakePanelActiveByIndex(int panelIndex)
    {
        for (int i = 0; i < mnemos.Count; i++)
        {
            if (i != panelIndex && i != 0)
            {
                mnemos[i].SetActive(false);
            }
        }
        mnemos[0].SetActive(true);
        mnemos[panelIndex].SetActive(true);
    }

    private void MakeButtonGray(int panelIndex)
    {
        for (int i = 0; i < imagesOfMnemoButtons.Count; i++)
        {
            if (i != panelIndex)
            {
                imagesOfMnemoButtons[i].color = Color.white;
            }
        }
        imagesOfMnemoButtons[panelIndex].color = buttonColorAfterClicking;
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemos = new List<GameObject>() {
        mnemoZero, mnemoOne, mnemoTwo, mnemoThree, mnemoFour, _button05Mneomo, _button06Mneomo,
        _button07Mneomo, _button08Mneomo, _button09Mneomo, _button10Mneomo, _button11Mneomo, _button12Mneomo,
        _button13Mneomo, _button14Mneomo, _button15Mneomo, _button16Mneomo, _button17Mneomo};
        mnemos[0].SetActive(true);
        for (int i = 1; i < mnemos.Count; i++)
        {
            mnemos[i].SetActive(false);
        }

        imagesOfMnemoButtons = new List<Image>() {
        plugOfZeroImage, mnemoOneButtonImage, mnemoTwoButtonImage, mnemoThreeButtonImage, mnemoFourButtonImage, _button05MneomoImage, _button06MneomoImage,
        _button07MneomoImage, _button08MneomoImage, _button09MneomoImage, _button10MneomoImage, _button11MneomoImage, _button12MneomoImage,
        _button13MneomoImage, _button14MneomoImage, _button15MneomoImage, _button16MneomoImage, _button17MneomoImage};
        for (int i = 0; i < imagesOfMnemoButtons.Count; i++)
        {
            imagesOfMnemoButtons[i].color = Color.white;
        }
    }
}
