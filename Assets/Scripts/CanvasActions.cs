using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActions : MonoBehaviour
{
    [SerializeField] private GameObject GeneralPanel;
    [SerializeField] private GameObject ARM1Panel;
    [SerializeField] private GameObject ARM2Panel;

    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject ARM1MainPanel;
    [SerializeField] private GameObject ARM2MainPanel;

    public void OpenARM1Panel()
    {
        ARM2Panel.SetActive(false);
        GeneralPanel.SetActive(false);
        ARM1Panel.SetActive(true);

        MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);
        ARM1MainPanel.SetActive(true);
    }

    public void OpenARM2Panel()
    {
        ARM2Panel.SetActive(true);
        ARM1Panel.SetActive(false);
        GeneralPanel.SetActive(false);

        MainPanel.SetActive(false);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(true);
    }

    public void OpenGeneralPanel()
    {
        ARM1Panel.SetActive(false);
        ARM2Panel.SetActive(false);
        GeneralPanel.SetActive(true);

        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);
        MainPanel.SetActive(true); 
    }

    // Start is called before the first frame update
    void Start()
    {
        GeneralPanel.SetActive(true);
        ARM1Panel.SetActive(false);
        ARM2Panel.SetActive(false);

        MainPanel.SetActive(true);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);
    }
}
