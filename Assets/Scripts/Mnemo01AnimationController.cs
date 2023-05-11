using UnityEngine;
using UnityEngine.UI;

public class Mnemo01AnimationController : MonoBehaviour
{
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

    public GameObject Mag;

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
        animmnemo02 = Mnemo02.GetComponent<Animation>();
        animmnemo03 = Mnemo03.GetComponent<Animation>();
        Shiber.Play("DoorMoving", 0, 0f);
        Shiber.enabled = false;

        LojementCarkasTvs.Play("LogementArriving", 0, 0f);
        LojementCarkasTvs.enabled = false;
        //animmnemo01.Play();
        infoAboutTVSNumberOn01Mnemo.text = "";
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

    public void Mnemo01OffMnemo02Andnemo03On()
    {
        generalPanelAcions.SetPanelActive(Mnemo02);
        additionalGeneralPanelAcions.SetPanelActive(Mnemo03);
        imageOf03MnemoButton.color = buttonColorAfterClicking;

        Mag.SetActive(true);
        animmnemo02.Play();
        animmnemo03.Play();
    }

    public void Mnemo03On()
    {
        additionalGeneralPanelAcions.SetPanelActive(Mnemo03);
        imageOf03MnemoButton.color = buttonColorAfterClicking;
        //Mnemo03.SetActive(true);
        Shiberm.SetActive(false);
        Ramka.SetActive(false);
        M03m.SetActive(false);
    }
}
