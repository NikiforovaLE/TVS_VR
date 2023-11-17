using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo8Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo8;

    private readonly string moveTvsToWashingCommand = "������ ������� \"����������� ��� � ���� \"�������\"\"";
    private readonly string moveTvsToDryingCommand = "������ ������� \"����������� ��� � ���� \"�����\"\"";
    private readonly string moveTvsToTightnessControlCommand = "������ ������� \"����������� ��� � ���� \"�������������\"\"";
    private readonly string moveTvsToImpurityControlCommand = "������ ������� \"����������� ��� � ���� \"�������������\"\"";
    private readonly string moveTvsToWeightControlCommand = "������ ������� \"����������� ��� � ���� \"�����, ����������\"\"";
    private readonly string moveTvsToGeometryControlCommand = "������ ������� \"����������� ��� � ���� \"���������\"\"";

    private readonly string openWashRetortCommand = "������ ������� \"������� ������ ������� �������\"";
    private readonly string openDryingRetortCommand = "������ ������� \"������� ������ ������� �����\"";
    private readonly string openTightnessRetortCommand = "������ ������� \"������� ������ ������� �������������\"";

    private readonly string washRetortIsOpened = "������ ������� ������� �������";
    private readonly string dryingRetortIsOpened = "������ ������� ����� �������";
    private readonly string tightnessRetortIsOpened = "������ ������� ������������� �������";

    private readonly string closeWashRetortCommand = "������ ������� \"������� ������ ������� �������\"";
    private readonly string closeDryingRetortCommand = "������ ������� \"������� ������ ������� �����\"";
    private readonly string closeTightnessRetortCommand = "������ ������� \"������� ������ ������� �������������\"";

    private readonly string washRetortIsClosed = "������ ������� ������� �������";
    private readonly string dryingRetortIsClosed = "������ ������� ����� �������";
    private readonly string tightnessRetortIsClosed = "������ ������� ������������� �������";

    private readonly string messageSourceIsCoordinateManipulator = "������������ ������������ �����������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void MoveTvsToWashingCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToWashingCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }

    public void MoveTvsToDryingCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToDryingCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToTightnessControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToTightnessControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToImpurityControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToImpurityControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToWeightControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToWeightControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToGeometryControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToGeometryControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenWashRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openWashRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenDryingRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openDryingRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenTightnessRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openTightnessRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetWashRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(washRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetDryingRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(dryingRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetTightnessRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(tightnessRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseWashRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeWashRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseDryingRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeDryingRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseTightnessRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeTightnessRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetWashRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(washRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetDryingRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(dryingRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetTightnessRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(tightnessRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
}
