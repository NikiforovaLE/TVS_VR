using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARM1Button : MonoBehaviour
{
    public Button Arm1Button;
    public GameObject ButtonsPanel;
    public GameObject ButtonsPanelARM1;
    public GameObject MainPanel;
    public GameObject PanelARM1;


    public void ClickARM1Button() 
    {
        ButtonsPanel.SetActive(false);
        ButtonsPanelARM1.SetActive(true);
        MainPanel.SetActive(false);
        PanelARM1.SetActive(true);
    }
}
