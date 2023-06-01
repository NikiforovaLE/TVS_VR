using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo09Animation : MonoBehaviour
{
    [SerializeField] private GameObject mnemo10;
    [SerializeField] private Text currentTVS;
    public ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private Animation Mnemo10Animation;
    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;

    // Start is called before the first frame update
    void Start()
    {
        currentTVS.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
    }

    public void ShowMnemo10()
    {
        GeneralPanelAcions.SetPanelActive(mnemo10);
    }

    public void Start10MnemoAnimation()
    {
        Mnemo10Animation.Play();
    }
}
