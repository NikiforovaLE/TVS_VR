using UnityEngine;
using UnityEngine.UI;
using Oculus.Interaction;

public class Mnemo13Animation : MonoBehaviour
{
    [SerializeField] private Text lengthControlIsDoneText;
    [SerializeField] private Text sizeControlIsDoneText;
    [SerializeField] private Text viewControlIsDoneText;
    [SerializeField] private Text attentionMessage;

    [SerializeField] private Image isPerformingBackgrond;

    [SerializeField] private Mnemo12Animation mnemo12Animation;

    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private Animator mnemo14Animator;

    [SerializeField] private GeneralPanelAcions generalPanelAcions;
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;

    [SerializeField] private GameObject mnemo14;
    [SerializeField] private GameObject mnemo16;
    [SerializeField] private GameObject isSuitableButton;
    [SerializeField] private GameObject defectButton;

    private Animator currentAnimator;
    private bool mnemo12isChecked;
    private bool mnemo13IsChecked;

    private readonly Color whenIsNotPerforming = new(255f, 255f, 255f, 255f);
    private readonly Color whenIsPerforming = new(0f, 255f, 0f, 255f);
    private readonly string done = "Выполнен";
    private readonly string messageWhenNotChecked = "Проведите проверку";

    // Start is called before the first frame update
    void Start()
    {
        mnemo13IsChecked = false;
        attentionMessage.text = "";
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mnemo12isChecked = mnemo12Animation.IsChecked;
    }

    public void StartControl()
    {
        if (mnemo12isChecked)
        {
            currentAnimator.Play("13 Mnemo Animation");
            MakeButtonsUnPointable();
            attentionMessage.text = "";
            isPerformingBackgrond.color = whenIsPerforming;
            mnemo08Animator.speed = 1;
        }
    }

    private void MakeButtonsUnPointable()
    {
        isSuitableButton.GetComponent<PointableUnityEventWrapper>().enabled = false;
        defectButton.GetComponent<PointableUnityEventWrapper>().enabled = false;
    }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = done;
    }

    public void SetLengthControlIsDone()
    {
        IsDone(lengthControlIsDoneText);
    }

    public void SetSizeControlIsDone()
    {
        IsDone(sizeControlIsDoneText);
    }

    public void SetViewControlIsDoneText()
    {
        IsDone(viewControlIsDoneText);
    }

    public void MakeButtonsPointable()
    {
        isSuitableButton.GetComponent<PointableUnityEventWrapper>().enabled = true;
        defectButton.GetComponent<PointableUnityEventWrapper>().enabled = true;
    }

    public void MakeMnemo13IsCheckedTrue()
    {
        mnemo13IsChecked = true;
        isPerformingBackgrond.color = whenIsNotPerforming;
    }

    public void IsSuitable()
    {
        if (mnemo13IsChecked)
        {
            attentionMessage.text = "";
            generalPanelAcions.SetPanelActive(mnemo14);
            additionalGeneralPanelAcions.SetPanelActive(mnemo16);
        }
        else
        {
            attentionMessage.text = messageWhenNotChecked;
        }
    }
}
