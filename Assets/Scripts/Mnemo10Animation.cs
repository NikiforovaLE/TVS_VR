using System;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo10Animation : MonoBehaviour
{
    [SerializeField] private Text validityText;
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text PChS;
    [SerializeField] private Image isPerformedPanel;
    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GameObject mnemo11;
    [SerializeField] private Mnemo10Messages mnemo10Messages;

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
        mnemo10Messages.StartSensitivityTest();
        SetValidity();
        isPerformedPanel.color = new(0f, 255f, 0f, 100f);
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

    private void MakeIsPerformedPanelGray()
    {
        isPerformedPanel.color = new Color(255f, 255f, 255f, 100f);
    }
}