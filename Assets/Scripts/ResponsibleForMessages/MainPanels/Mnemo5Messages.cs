using UnityEngine;

public class Mnemo5Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo5;

    private readonly string moveToAssemblyPositionCommand = "������ ������� \"������������� �� ������� ������ �����\"";
    private readonly string autooperatorIsAtAssemblyPosition = "������������ �� ������� ������ �����";

    private readonly string moveToDefectFrameDisassemblyPositionCommand = "������ ������� \"������������� �� ������� �������� ���������� �������\"";
    private readonly string autooperatorIsAtDefectFrameDisassemblyPosition = "������������ �� ������� �������� ���������� �������";

    private readonly string grabLodgementCommand = "������ ������� \"��������� ��������-���������\"";
    private readonly string lodgementIsCaptured = "��������-��������� ��������";

    private readonly string moveToTitlerPositionCommand = "������ ������� \"������������� �� ������� �����������\"";
    private readonly string autooperatorIsAtTitlerPosition = "������������ �� ������� �����������";

    private readonly string releaseCaptureOfLodgementCommand = "������ ������� \"���������� ������ ���������-���������\"";
    private readonly string captureOfLodgementIsReleased = "������ ���������-��������� ���������";

    private readonly string messageSourceIsAssembly = "������ ���";
    private readonly string messageSourceIsOperator = "������������";

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
