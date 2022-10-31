using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMPanelActions : MonoBehaviour
{
    [SerializeField] private GameObject mnemoZero;
    [SerializeField] private GameObject mnemoOne;
    [SerializeField] private GameObject mnemoTwo;
    [SerializeField] private GameObject mnemoThree;
    [SerializeField] private GameObject mnemoFour;
    [SerializeField] Animation animOfMnemoZero;
    [SerializeField] Animation animOfMnemoOne;
    [SerializeField] Animation animOfMnemoTwo;
    [SerializeField] Animation animOfMnemoThree;
    [SerializeField] Animation animOfMnemoFour;

    private List<GameObject> mnemos;
    private List<Animation> animationsOfMnemos;

    public void ShowMnemoPanel(GameObject buttonMnemo)
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
        mnemos = new List<GameObject>() { mnemoZero, mnemoOne, mnemoTwo, mnemoThree, mnemoFour };
        mnemos[0].SetActive(true);
        for (int i = 1; i < mnemos.Count; i++)
        {
            mnemos[i].SetActive(false);
        }
        animationsOfMnemos = new List<Animation>() { animOfMnemoZero, animOfMnemoOne, animOfMnemoTwo, animOfMnemoThree, animOfMnemoFour };
    }
}
