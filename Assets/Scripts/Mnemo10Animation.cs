using System;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo10Animation : MonoBehaviour
{
    [SerializeField] private Text validityText;
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text PChS;
    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GameObject mnemo11;

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


    public void StartControl()
    {
        SetValidity();
        PChS.text = "1*10-13";
        gameObject.GetComponent<Animator>().Play("10 Mnemo Animation");
        mnemo08Animator.speed = 1;
    }

    private void SetValidity()
    {
        validityText.text = DateTime.Now.AddDays(3).ToString();
    }


    public void Show11Mnemo()
    {
        GeneralPanelAcions.SetPanelActive(mnemo11);
    }
}
