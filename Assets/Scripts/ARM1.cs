using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARM1 : MonoBehaviour
{
    [SerializeField] private GameObject ARM1Panel;
    [SerializeField] private GameObject GeneralPanel;

    public void ClickARM1()
    {
        ARM1Panel.SetActive(true);
        GeneralPanel.SetActive(false);
    }

    public void ClickMainView()
    {
        ARM1Panel.SetActive(false);
        GeneralPanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        ARM1Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     /*   if (OVRInput.Get(OVRInput.Button.One))
        {
            ClickARM1();
            Debug.Log("A button pressed");
        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            ClickMainView();
            Debug.Log("B button pressed");
        }*/
    }
}
