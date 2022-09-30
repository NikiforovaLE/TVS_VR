using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject Panel;

    public void ClickARM1()
    {
        Panel.SetActive(true);
       // GeneralPanel.SetActive(false);
    }

    public void ClickMainView()
    {
        Panel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
