using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo05Info : MonoBehaviour
{
    [SerializeField] private Text verticalPositionText;
    [SerializeField] private Text stateGripsText;
    [SerializeField] private Text destinationPositionText;

    private List<string> verticalPosition;
    private int countverticalPosition = 0;

    private readonly string gripsAreOpened = "Открыты";
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
        stateGripsText.text = gripsAreOpened;
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
