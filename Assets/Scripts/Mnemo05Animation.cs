using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo05Animation : MonoBehaviour
{
    public Animator Autooperator;
    public GameObject TVSframe;
    public GameObject TVSframeAutooperator;
    public Transform Tilter;
    public GameObject Mnemo04Add;
    public GameObject Mnemo06Add;
    public GameObject Mnemo07;
    public GameObject Mnemo05;

    private List<string> verticalPosition;

    [SerializeField] private Text verticalPositionText;
    [SerializeField] private Text stateGripsText;
    [SerializeField] private Text destinationPositionText;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GeneralPanelAcions AdditionalGeneralPanelAcions;

    private int countverticalPosition = 0;

    private readonly string gripsAreOpen = "Открыты";
    private readonly string gripsAreClosed = "Закрыты";

    private readonly string destinationPositionIsBundleAssembly = "Сборка пучка";
    private readonly string destinationPositionIsDefectFrameDisassembly = "Разборка дефектного каркаса";
    private readonly string destinationPositionIsTvsAssembly = "Сборка ТВС";

    // Start is called before the first frame update
    void Start()
    {
        verticalPosition = new List<string> { "Верхнее", "Нижнее" };
        verticalPositionText.text = verticalPosition[countverticalPosition];
    }

    public void StartActions()
    {
        TVSframe.SetActive(false);
        TVSframeAutooperator.SetActive(true);
    }

    public void AutooperatorRun()
    {
        Autooperator.Play("MoveLodgementToAsembly", 0, 0f);
    }

    public void TitlerTvsRun()
    {
        Autooperator.enabled = false;
        TVSframeAutooperator.transform.SetParent(Tilter);
        AdditionalGeneralPanelAcions.SetPanelActive(Mnemo06Add);
        GeneralPanelAcions.SetPanelActive(Mnemo07);
        //Mnemo05.SetActive(false);
        //Mnemo04Add.SetActive(false);
        //Mnemo06Add.SetActive(true);
        //Mnemo07.SetActive(true);
    }

    public void MakeVerticalPositionLower()
    {
        countverticalPosition++;
        verticalPositionText.text = verticalPosition[countverticalPosition];
    }

    public void MakeVerticalPositionUpper()
    {
        countverticalPosition--;
        verticalPositionText.text = verticalPosition[countverticalPosition];
    }

    public void CloseGrips()
    {
        stateGripsText.text = gripsAreClosed;
    }

    public void OpenGrips()
    {
        stateGripsText.text = gripsAreOpen;
    }

    public void SetDestinationPositionIsBundleAssembly()
    {
        destinationPositionText.text = destinationPositionIsBundleAssembly;
    }

    public void SetDestinationPositionIsDefectFrameDisassembly()
    {
        destinationPositionText.text = destinationPositionIsDefectFrameDisassembly;
    }
    
    public void SetDestinationPositionIsTvsAssembly()
    {
        destinationPositionText.text = destinationPositionIsTvsAssembly;
    }
}
