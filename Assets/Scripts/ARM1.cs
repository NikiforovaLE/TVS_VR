using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARM1 : MonoBehaviour
{
    public GameObject PanelArm;
    public GameObject PanelButtons;

    public void ClickARM1()
    {
        PanelButtons.SetActive(true);
        PanelArm.SetActive(false);
    }

    public void ClickBack()
    {
        PanelButtons.SetActive(false);
        PanelArm.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        PanelButtons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Space key was pressed.");
            ClickARM1();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Space key was pressed.");
            ClickBack();
        }

    }
}
