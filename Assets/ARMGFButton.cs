using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARMGFButton: MonoBehaviour
{
    public Button ButtonGF;
    public GameObject ButtonsPanel;
    public GameObject ButtonsPanelARM1;
    public GameObject MainPanel;
    public GameObject PanelARM1;

    public void ClickARMGFButton()
    {
        ButtonsPanel.SetActive(true);
        ButtonsPanelARM1.SetActive(false);
        MainPanel.SetActive(true);
        PanelARM1.SetActive(false);
    }
}
