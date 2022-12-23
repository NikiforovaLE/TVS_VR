using UnityEngine;
using UnityEngine.UI;

public class Mnemo01AnimationController : MonoBehaviour
{
    private Animation animmnemo01;
    private Animation animmnemo02;
    private Animation animmnemo03;

    public Animator Shiber;
    public Animator LojementCarkasTvs;
    public GameObject LojementSvidetelSborkaPuchka;

    public GameObject Mnemo01;
    public GameObject Mnemo02;
    public GameObject Mnemo03;

    public GameObject Shiberm;
    public GameObject Ramka;
    public GameObject M03m;

    public GeneralPanelAcions generalPanelAcions;
    public GeneralPanelAcions additionalGeneralPanelAcions;
    public ARM1Mnemo2 ARM1Mnemo2;
    public Text infoAboutContainerNumberOn01Mnemo;
    [SerializeField] private Text infoAboutTVSNumberOn01Mnemo;
    [SerializeField] private Image imageOf03MnemoButton;

    private string currentFrame;
    private Color buttonColorAfterClicking = new(200f / 255f, 200f / 255f, 200f / 255f);
    public string CurrentFrame { get => currentFrame; set => currentFrame = value; }

    // Start is called before the first frame update
    void Start()
    {
        animmnemo01 = Mnemo01.GetComponent<Animation>();
        animmnemo02 = Mnemo02.GetComponent<Animation>();
        animmnemo03 = Mnemo03.GetComponent<Animation>();
        Shiber.Play("DoorMoving", 0, 0f);
        Shiber.enabled = false;

        LojementCarkasTvs.Play("LogementArriving", 0, 0f);
        LojementCarkasTvs.enabled = false;
        animmnemo01.Play();
        infoAboutTVSNumberOn01Mnemo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        animmnemo01.Play();

    }

    public void ShiberPlay()
    {
        Shiber.enabled = true;
        Shiber.GetComponent<AudioSource>().Play();  
        infoAboutTVSNumberOn01Mnemo.text = ARM1Mnemo2.NumberOfContainersAndFrames[infoAboutContainerNumberOn01Mnemo.text];
    }

    public void ShiberStop()
    {
        Shiber.enabled = false;
    }

    public void LojementCarkasTvsPlay()
    {
        LojementCarkasTvs.enabled = true;
        LojementCarkasTvs.GetComponent<AudioSource>().Play();
    }

    public void LojementCarkasTvsStop()
    {
        LojementCarkasTvs.enabled = false;
    }

    public void Mnemo01OffMnemo02On()
    {
        generalPanelAcions.SetPanelActive(Mnemo02);
        //Mnemo01.SetActive(false);
        //Mnemo02.SetActive(true);
        Mnemo03On();
        animmnemo02.Play();
        animmnemo03.Play();
    }

    public void Mnemo03On()
    {
        additionalGeneralPanelAcions.SetPanelActive(Mnemo03);
        imageOf03MnemoButton.color = buttonColorAfterClicking;
        //Mnemo03.SetActive(true);
        //Shiberm.SetActive(false);
        //Ramka.SetActive(false);
        //M03m.SetActive(false);
    }
}
