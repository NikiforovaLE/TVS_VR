using UnityEngine;

public class Mnemo5Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo5;

    private readonly string moveToAssemblyPositionCommand = "Выдана команда \"Переместиться на позицию сборки пучка\"";
    private readonly string autooperatorIsAtAssemblyPosition = "Автооператор на позиции сборки пучка";

    private readonly string moveToDefectFrameDisassemblyPositionCommand = "Выдана команда \"Переместиться на позицию разборки дефектного каркаса\"";
    private readonly string autooperatorIsAtDefectFrameDisassemblyPosition = "Автооператор на позиции разборки дефектного каркаса";

    private readonly string grabLodgementCommand = "Выдана команда \"Захватить ложемент-свидетель\"";
    private readonly string lodgementIsCaptured = "Ложемент-свидетель захвачен";

    private readonly string moveToTitlerPositionCommand = "Выдана команда \"Переместиться на позицию кантователя\"";
    private readonly string autooperatorIsAtTitlerPosition = "Автооператор на позиции кантователя";

    private readonly string releaseCaptureOfLodgementCommand = "Выдана команда \"Освободить захват ложемента-свидетеля\"";
    private readonly string captureOfLodgementIsReleased = "Захват ложемента-свидетеля освобождён";

    private readonly string messageSourceIsAssembly = "Сборка ТВС";
    private readonly string messageSourceIsOperator = "Автооператор";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void MoveToAssemblyPosition()
    {
        messageInfoOnMnemo5.FillInfo(moveToAssemblyPositionCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetAutooperatorIsAtAssemblyPosition()
    {
        messageInfoOnMnemo5.FillInfo(autooperatorIsAtAssemblyPosition, messageSourceIsAssembly, positiveStatus);
    }

    public void MoveToDefectFrameDisassemblyPosition()
    {
        messageInfoOnMnemo5.FillInfo(moveToDefectFrameDisassemblyPositionCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetAutooperatorIsAtDefectFrameDisassemblyPosition()
    {
        messageInfoOnMnemo5.FillInfo(autooperatorIsAtDefectFrameDisassemblyPosition, messageSourceIsAssembly, positiveStatus);
    }
    
    public void GrabLodgement()
    {
        messageInfoOnMnemo5.FillInfo(grabLodgementCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetLodgementIsCaptured()
    {
        messageInfoOnMnemo5.FillInfo(lodgementIsCaptured, messageSourceIsAssembly, positiveStatus);
    }
    
    public void MoveToTitlerPosition()
    {
        messageInfoOnMnemo5.FillInfo(moveToTitlerPositionCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetAutooperatorIsAtTitlerPosition()
    {
        messageInfoOnMnemo5.FillInfo(autooperatorIsAtTitlerPosition, messageSourceIsAssembly, positiveStatus);
    }
    
    public void ReleaseCaptureOfLodgement()
    {
        messageInfoOnMnemo5.FillInfo(releaseCaptureOfLodgementCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetCaptureOfLodgementIsReleased()
    {
        messageInfoOnMnemo5.FillInfo(captureOfLodgementIsReleased, messageSourceIsAssembly, positiveStatus);
    }
}
