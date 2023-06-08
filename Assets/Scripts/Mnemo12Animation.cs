using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Animation : MonoBehaviour
{
    [SerializeField] private Text step;
    [SerializeField] private Text tvsWeightLossText;
    [SerializeField] private Text suzWeightLossText;
    [SerializeField] private Text weightControlIsDoneText;
    [SerializeField] private Text inputControlIsDoneText;
    [SerializeField] private Text lockControlIsDoneText;
    [SerializeField] private Text suzControlIsDoneText;

    private Animator currentAnimator;
    private bool isChecked;

    private readonly string done = "��������";

    public bool IsChecked { get => isChecked; set => isChecked = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    public void StartControl()
    {
        currentAnimator.Play("12 Mnemo Animation");
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

    public void SetTvsWeightLoss()
    {
        tvsWeightLossText.text = "230";
    }

    public void SetSuzWeightLoss()
    {
        suzWeightLossText.text = "60";
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
    }
}