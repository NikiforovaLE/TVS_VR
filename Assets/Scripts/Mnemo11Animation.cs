using UnityEngine;
using UnityEngine.UI;

public class Mnemo11Animation : MonoBehaviour
{
    [SerializeField] private GameObject mnemo12;
    [SerializeField] private Text currentTVS;
    [SerializeField] private Text performedText;
    [SerializeField] private Image suitableButton;
    [SerializeField] private Image defectiveButton;
    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;

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
            suitableButton.color = new Color(0f, 255f, 0f, 255f);
            defectiveButton.color = new Color(255f, 255f, 255f, 255f);
            GeneralPanelAcions.SetPanelActive(mnemo12);
        }
    }

    public void SetDefective()
    {
        if (currentAnimator.GetBool("wasPerfomed"))
        {
            IsSuitable = false;
            suitableButton.color = new Color(255f, 255f, 255f, 255f);
            defectiveButton.color = new Color(255f, 0f, 0f, 255f);
        }
    }
}
