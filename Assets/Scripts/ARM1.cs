using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARM1 : MonoBehaviour
{
    public GameObject ButtonsPanelARM1;
    public GameObject ButtonsPanel;

    public void ClickARM1()
    {
        ButtonsPanelARM1.SetActive(true);
        ButtonsPanel.SetActive(false);
    }

    public void ClickMainView()
    {
        ButtonsPanelARM1.SetActive(false);
        ButtonsPanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        ButtonsPanelARM1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            ClickARM1();
            Debug.Log("A button pressed");
        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            ClickMainView();
            Debug.Log("B button pressed");
        }
    }
}
