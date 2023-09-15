using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasActions : MonoBehaviour
{
    [SerializeField] private GameObject GeneralPanel;
    [SerializeField] private GameObject ARM1Panel;
    [SerializeField] private GameObject ARM2Panel;
    [SerializeField] private GameObject GeneralMessagePanel;
    [SerializeField] private GameObject ARM1MessagePanel;
    [SerializeField] private GameObject ARM2MessagePanel;

    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject ARM1MainPanel;
    [SerializeField] private GameObject ARM2MainPanel;

    [SerializeField] private GameObject mnemo00;
    [SerializeField] private GeneralPanelAcions generalPanelAcions;

    [SerializeField] private Image GneralPanelButton;
    [SerializeField] private Image ARM1PanelButton;
    [SerializeField] private Image ARM2PanelButton;

    private Color buttonColorAfterClicking = new(200f / 255f, 200f / 255f, 200f / 255f);
    public void OpenARM1Panel()
    {
        GneralPanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;
        ARM1PanelButton.color = buttonColorAfterClicking;

        ARM2Panel.SetActive(false);
        GeneralPanel.SetActive(false);
        ARM1Panel.SetActive(true);

        generalPanelAcions.SetPanelActive(mnemo00);
        ARM2MainPanel.SetActive(false);
        ARM1MainPanel.SetActive(true);

        GeneralMessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(false);
        ARM1MessagePanel.SetActive(true);
    }

    public void OpenARM2Panel()
    {
        GneralPanelButton.color = Color.white;
        ARM1PanelButton.color = Color.white;
        ARM2PanelButton.color = buttonColorAfterClicking;

        ARM2Panel.SetActive(true);
        ARM1Panel.SetActive(false);
        GeneralPanel.SetActive(false);

        generalPanelAcions.SetPanelActive(mnemo00);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(true);

        GeneralMessagePanel.SetActive(false);
        ARM1MessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(true);
    }

    public void OpenGeneralPanel()
    {
        ARM1PanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;
        GneralPanelButton.color = buttonColorAfterClicking;

        ARM1Panel.SetActive(false);
        ARM2Panel.SetActive(false);
        GeneralPanel.SetActive(true);

        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);
        //MainPanel.SetActive(true);

        ARM1MessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(false);
        GeneralMessagePanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        GneralPanelButton.color = Color.white;
        ARM1PanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;

        GeneralPanel.SetActive(true);
        ARM1Panel.SetActive(false);
        ARM2Panel.SetActive(false);

        MainPanel.SetActive(true);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);

        ARM1MessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(false);
        GeneralMessagePanel.SetActive(true);
    }
}
