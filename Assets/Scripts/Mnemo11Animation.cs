using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo11Animation : MonoBehaviour
{
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text performedText;
    [SerializeField] private Image suitableButton;
    [SerializeField] private Image defectiveButton;

    public ARM2Mnemo0 ARM2Mnemo0;
    private Animator currentAnimator;

    private readonly string whenPerformed = "выполнен";
    private bool isSuitable = false;

    public bool IsSuitable { get => isSuitable; set => isSuitable = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentTVS.text = "";
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTVS.text = ARM2Mnemo0.FrameNumber.text;
    }

    public void SetWasPerfomedTrue()
    {
        currentAnimator.SetBool("wasPerfomed", true);
        performedText.text = whenPerformed;
    }

    public void SetSuitable()
    {
        if (currentAnimator.GetBool("wasPerfomed"))
        {
            IsSuitable = true;
            suitableButton.color = Color.green;
            defectiveButton.color = Color.white;
        }
    }

    public void SetDefective()
    {
        if (currentAnimator.GetBool("wasPerfomed"))
        {
            IsSuitable = false;
            suitableButton.color = Color.white;
            defectiveButton.color = Color.red;
        }
    }
}
