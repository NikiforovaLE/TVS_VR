using UnityEngine.UI;
using UnityEngine;

public class CanvasActions : MonoBehaviour
{
    //LeftSidebars
    [SerializeField] private GameObject GeneralMenu;
    [SerializeField] private GameObject Arm1Menu;
    [SerializeField] private GameObject Arm2Menu;

    //TopPanels
    [SerializeField] private GameObject plugForGeneralMessagePanel;
    [SerializeField] private GameObject ARM1MessagePanel;
    [SerializeField] private GameObject ARM2MessagePanel;

    //MainPanels
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject ARM1MainPanel;
    [SerializeField] private GameObject ARM2MainPanel;

    [SerializeField] private GameObject mnemo00;
    [SerializeField] private GeneralPanelAcions generalPanelAcions;

    [SerializeField] private Image GneralPanelButton;
    [SerializeField] private Image ARM1PanelButton;
    [SerializeField] private Image ARM2PanelButton;

    [SerializeField] private Text arm1Message;
    [SerializeField] private Text arm2Message;

    private readonly string arm1InitialMessage = "Требуется получить контейнер с каркасом ТВС";
    private readonly string arm2InitialMessage = "";

    private readonly Color buttonColorAfterClicking = new(200f / 255f, 200f / 255f, 200f / 255f);

    public void OpenARM1Panel()
    {
        ARM1PanelButton.color = buttonColorAfterClicking;
        GneralPanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;

        Arm1Menu.SetActive(true);
        Arm2Menu.SetActive(false);
        GeneralMenu.SetActive(false);

        ARM1MainPanel.SetActive(true);
        generalPanelAcions.SetPanelActive(mnemo00);
        ARM2MainPanel.SetActive(false);

        ARM1MessagePanel.SetActive(true);
        ARM2MessagePanel.SetActive(false);
    }

    public void OpenARM2Panel()
    {
        ARM2PanelButton.color = buttonColorAfterClicking;
        GneralPanelButton.color = Color.white;
        ARM1PanelButton.color = Color.white;

        Arm2Menu.SetActive(true);
        Arm1Menu.SetActive(false);
        GeneralMenu.SetActive(false);

        ARM2MainPanel.SetActive(true);
        generalPanelAcions.SetPanelActive(mnemo00);
        ARM1MainPanel.SetActive(false);

        ARM2MessagePanel.SetActive(true);
        ARM1MessagePanel.SetActive(false);
    }

    public void OpenGeneralPanel()
    {
        GneralPanelButton.color = buttonColorAfterClicking;
        ARM1PanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;

        GeneralMenu.SetActive(true);
        Arm1Menu.SetActive(false);
        Arm2Menu.SetActive(false);

        generalPanelAcions.SetPanelActive(mnemo00);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);
        
        ARM1MessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        GneralPanelButton.color = Color.white;
        ARM1PanelButton.color = Color.white;
        ARM2PanelButton.color = Color.white;

        GeneralMenu.SetActive(true);
        Arm1Menu.SetActive(false);
        Arm2Menu.SetActive(false);

        MainPanel.SetActive(true);
        ARM1MainPanel.SetActive(false);
        ARM2MainPanel.SetActive(false);

        plugForGeneralMessagePanel.SetActive(true);
        ARM1MessagePanel.SetActive(false);
        ARM2MessagePanel.SetActive(false);

        arm1Message.text = arm1InitialMessage;
        arm2Message.text = arm2InitialMessage;
    }
}
