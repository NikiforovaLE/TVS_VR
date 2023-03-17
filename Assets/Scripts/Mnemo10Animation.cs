using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo10Animation : MonoBehaviour
{
    [SerializeField] private Text validityText;
    [SerializeField] private Text currentTVS;
    public ARM2Mnemo0 ARM2Mnemo0;
    // Start is called before the first frame update
    void Start()
    {
        validityText.text = "";
        currentTVS.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
    }

    public void SetValidity()
    {
        validityText.text = DateTime.Today.AddDays(3).ToString();
    }
}
