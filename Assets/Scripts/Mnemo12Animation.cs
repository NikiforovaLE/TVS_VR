using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Animation : MonoBehaviour
{
    [SerializeField] private Text currentTvs;
    [SerializeField] private Text tvsType;

    [SerializeField] private Text step;
    [SerializeField] private Text tvsWeightText;
    [SerializeField] private Text tvsWeightLossText;
    [SerializeField] private Text suzWeightLossText;
    [SerializeField] private Text weightControlIsDoneText;
    [SerializeField] private Text inputControlIsDoneText;
    [SerializeField] private Text lockControlIsDoneText;
    [SerializeField] private Text suzControlIsDoneText;
    [SerializeField] private Text captureText;
    [SerializeField] private Text rotationAngle;


    [SerializeField] private Image isPerformingBackgrond;

    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GameObject mnemo13;

    private Animator currentAnimator;
    private bool isChecked;

    private readonly string done = "Выполнен";
    private readonly Color whenIsNotPerforming = new(255f, 255f, 255f, 255f);
    private readonly Color whenIsPerforming = new(0f, 255f, 0f, 255f);
    public bool IsChecked { get => isChecked; set => isChecked = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTvs.text = ARM2Mnemo0.FrameNumber.text;
        tvsType.text = ARM2Mnemo0.Type.text;
    }

    public void StartControl()
    {
        currentAnimator.Play("12 Mnemo Animation");
        mnemo08Animator.speed = 1;
        isPerformingBackgrond.color = whenIsPerforming;
    }

    public void SetStep1()
    {
        step.text = "1";
    }

    public void SetStep2()
    {
        step.text = "2";
    }

    public void SetStep3()
    {
        step.text = "3";
    }

    public void SetTvsWeight()
    {
        tvsWeightText.text = "230";
    }

    public void SetTvsWeightLoss()
    {
        tvsWeightLossText.text = "60";
    }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = done;
    }

    public void SetWeightControlIsDone()
    {
        IsDone(weightControlIsDoneText);
    }

    public void SetInputControlIsDone()
    {
        IsDone(inputControlIsDoneText);
    }

    public void SetLockControlIsDone()
    {
        IsDone(lockControlIsDoneText);
    }

    public void SetSuzControlIsDone()
    {
        IsDone(suzControlIsDoneText);
        suzWeightLossText.text = "53";
        IsChecked = true;
        isPerformingBackgrond.color = whenIsNotPerforming;
    }

    public void Show13Mnemo()
    {
        GeneralPanelAcions.SetPanelActive(mnemo13);
    }
}