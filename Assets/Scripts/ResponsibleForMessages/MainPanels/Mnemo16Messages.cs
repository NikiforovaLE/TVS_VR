using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo16Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo16;

    private readonly string removeEmptyBoxCommand = "������ ������� \"������� �������� ����� �� ������������ �������\"";
    private readonly string moveCoordinateManipulatorToTransferCarCommand = "������ ������� \"����������� �� � ���� \"������� ������������\"\"";
    private readonly string loadBoxIntoTransferCarCommand = "������ ������� \"��������� �������� ����� � ������� ������������\"";
    private readonly string removeBoxFromTransportCarCommand = "������ ������� \"������� ����� � ��� �� ������� ������������\"";

    private readonly string emptyBoxIsRemoved = "�������� ����� �������� �� ������������ �������";
    private readonly string emptyBoxIsLoaded = "�������� ����� �������� � ������� ������������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsEmptyBoxTransportation = "��������������� ��������� ������";

    public void RemoveEmptyBoxCommand()
    {
        messageInfoOnMnemo16.FillInfo(removeEmptyBoxCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }

    public void MoveCoordinateManipulatorToTransferCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(moveCoordinateManipulatorToTransferCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }

    public void LoadBoxIntoTransferCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(loadBoxIntoTransferCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void RemoveBoxFromTransportCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(removeBoxFromTransportCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void SetEmptyBoxIsRemoved()
    {
        messageInfoOnMnemo16.FillInfo(emptyBoxIsRemoved, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void SetEmptyBoxIsLoaded()
    {
        messageInfoOnMnemo16.FillInfo(emptyBoxIsLoaded, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
}
