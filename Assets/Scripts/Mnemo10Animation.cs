using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo10Animation : MonoBehaviour
{
    [SerializeField] private Text validityText;

    // Start is called before the first frame update
    void Start()
    {
        validityText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValidity()
    {
        validityText.text = DateTime.Today.AddDays(3).ToString();
    }
}
