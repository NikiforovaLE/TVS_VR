using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo16Animation : MonoBehaviour
{
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text typeOfTVS;
    public ARM2Mnemo0 ARM2Mnemo0;
    // Start is called before the first frame update
    void Start()
    {
        currentTVS.text = "";
        typeOfTVS.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
        typeOfTVS.text = ARM2Mnemo0.Type.text;
    }
}