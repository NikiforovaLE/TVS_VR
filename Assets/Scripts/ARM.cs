using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARM : MonoBehaviour
{
    [SerializeField] private GameObject ARMpanel;

    public void ClickARM1()
    {
        ARMpanel.SetActive(true);
    }
    public void ClickMainView()
    {
        ARMpanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ARMpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
