using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ARMPanelActions : MonoBehaviour
{
    [SerializeField] private GameObject mnemoZero;
    [SerializeField] private GameObject mnemoOne;
    [SerializeField] private GameObject mnemoTwo;
    [SerializeField] private GameObject mnemoThree;
    [SerializeField] private GameObject mnemoFour;

    [SerializeField] private Image plugOfButtonZero;
    [SerializeField] private Image imageOfButtonOne;
    [SerializeField] private Image imageOfButtonTwo;
    [SerializeField] private Image imageOfButtonThree;
    [SerializeField] private Image imageOfButtonFour;

    private List<GameObject> mnemos;
    private List<Image> images;

    private Color buttonColorAfterClicking = new(200f / 255f, 200f / 255f, 200f / 255f);
    public void ShowMnemoPanel(GameObject mnemo)
    {
        int mnemoIndex = mnemos.IndexOf(mnemo);
        MakeMnemoActive(mnemoIndex);
        MakeButtonGray(mnemoIndex);
    }

    private void MakeMnemoActive(int panelIndex)
    {
        for (int i = 0; i < mnemos.Count; i++)
        {
            if (i != panelIndex)
            {
                mnemos[i].SetActive(false);
            }
        }
        mnemos[panelIndex].SetActive(true);
    }

    private void MakeButtonGray(int panelIndex)
    {
        for (int i = 0; i < images.Count; i++)
        {
            if (i != panelIndex)
            {
                images[i].color = Color.white;
            }
        }
        images[panelIndex].color = buttonColorAfterClicking;
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemos = new List<GameObject>() { mnemoZero, mnemoOne, mnemoTwo, mnemoThree, mnemoFour };
        mnemos[0].SetActive(true);
        for (int i = 1; i < mnemos.Count; i++)
        {
            mnemos[i].SetActive(false);
        }

        images = new List<Image>() { plugOfButtonZero, imageOfButtonOne, imageOfButtonTwo, imageOfButtonThree, imageOfButtonFour };
        for (int i = 0; i < images.Count; i++)
        {
            images[i].color = Color.white;
        }
    }
}
