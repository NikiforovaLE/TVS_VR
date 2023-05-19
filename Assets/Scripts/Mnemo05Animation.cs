using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo05Animation : MonoBehaviour
{

    private Animation animmnemo05;
    public Animator Autooperator;
    public GameObject TVSframe;
    public GameObject TVSframeAutooperator;
    public Transform Tilter;
    public GameObject Mnemo04Add;
    public GameObject Mnemo06Add;
    public GameObject Mnemo07;
    public GameObject Mnemo05;

    private List<string> verticalPosition;
    private List<string> stateGrips;
    private List<string> destinationPosition;

    [SerializeField] private Text verticalPositionText;
    [SerializeField] private Text stateGripsText;
    [SerializeField] private Text destinationPositionText;

    private int countverticalPosition = 0;
    private int countstateGrips = 0;
    private int countdestinationPosition = 0;


    // Start is called before the first frame update
    void Start()
    {
        animmnemo05 = gameObject.GetComponent<Animation>();

        verticalPosition = new List<string> { "Верхнее", "Нижнее" };
        stateGrips = new List<string> { "Открыты", "Закрыты" };
        destinationPosition = new List<string> { "Сборка пучка", "Разборка дефектного каркаса", "Сборка ТВС"};
        verticalPositionText.text = verticalPosition[countverticalPosition];
        stateGripsText.text = stateGrips[countstateGrips];
        destinationPositionText.text = destinationPosition[countdestinationPosition];
    }


    void Update()
    {
        TVSframe.SetActive(false);
        TVSframeAutooperator.SetActive(true);
        //animmnemo05.Play();
    }

    public void AutooperatorRun()
    {
        Autooperator.Play("Third_new", 0, 0f);
    }

    public void TitlerTvsRun()
    {
        Autooperator.enabled = false;
        TVSframeAutooperator.transform.SetParent(Tilter);
        Mnemo05.SetActive(false);
        Mnemo04Add.SetActive(false);
        Mnemo06Add.SetActive(true);
        Mnemo07.SetActive(true);
    }

    public void verticalPositionLower()
    {
        countverticalPosition++;
        verticalPositionText.text = verticalPosition[countverticalPosition];
    }

    public void verticalPositionUpper()
    {
        countverticalPosition--;
        verticalPositionText.text = verticalPosition[countverticalPosition];
    }

    public void stateGripsClose()
    {
        countstateGrips++;
        stateGripsText.text = stateGrips[countstateGrips];
    }

    public void stateGripsOpen()
    {
        countstateGrips--;
        stateGripsText.text = stateGrips[countstateGrips];
    }

    public void destinationPositionForward()
    {
        countdestinationPosition++;
        destinationPositionText.text = destinationPosition[countdestinationPosition];
    }

    public void destinationPositionBack()
    {
        countdestinationPosition--;
        destinationPositionText.text = destinationPosition[countdestinationPosition];
    }
}
