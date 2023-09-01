using UnityEngine;

public class Mnemo9Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo9;

    private readonly string openWashingShiberCommand = "������ ������� \"������� ����� ������� �������\"";
    private readonly string closeWashingShiberCommand = "������ ������� \"������� ����� ������� �������\"";

    private readonly string washingShiberIsOpened = "����� ������� ������� ������";
    private readonly string washingShiberIsClosed = "����� ������� ������� ������";

    private readonly string openDryingShiberCommand = "������ ������� \"������� ����� ������� �����\"";
    private readonly string closeDryingShiberCommand = "������ ������� \"������� ����� ������� �����\"";

    private readonly string dryingShiberIsOpened = "����� ������� ����� ������";
    private readonly string dryingShiberIsClosed = "����� ������� ����� ������";

    private readonly string startWashingCommand = "������ ������� \"������ �������\"";
    private readonly string startDryingCommand = "������ ������� \"������ �����\"";

    private readonly string washingIsFinished = "������� ���������";
    private readonly string dryingIsFinished = "����� ���������";

    private readonly string messageSourceIsWashing = "�������";
    private readonly string messageSourceIsDrying = "�����";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenWashingShiber()
    {
        messageInfoOnMnemo9.FillInfo(openWashingShiberCommand, messageSourceIsWashing, positiveStatus);
    }
    
    public void SetWashingShiberIsOpened()
    {
        messageInfoOnMnemo9.FillInfo(washingShiberIsOpened, messageSourceIsWashing, positiveStatus);
    }
    
    public void CloseWashingShiber()
    {
        messageInfoOnMnemo9.FillInfo(closeWashingShiberCommand, messageSourceIsWashing, positiveStatus);
    }

    public void SetWashingShiberIsClosed()
    {
        messageInfoOnMnemo9.FillInfo(washingShiberIsClosed, messageSourceIsWashing, positiveStatus);
    }
    
    public void StartWashing()
    {
        messageInfoOnMnemo9.FillInfo(startWashingCommand, messageSourceIsWashing, positiveStatus);
    }
    
    public void SetWashingIsFinished()
    {
        messageInfoOnMnemo9.FillInfo(washingIsFinished, messageSourceIsWashing, positiveStatus);
    }
    
    public void OpenDryingShiber()
    {
        messageInfoOnMnemo9.FillInfo(openDryingShiberCommand, messageSourceIsDrying, positiveStatus);
    }

    public void SetDryingShiberIsOpened()
    {
        messageInfoOnMnemo9.FillInfo(dryingShiberIsOpened, messageSourceIsDrying, positiveStatus);
    }

    public void CloseDryingShiber()
    {
        messageInfoOnMnemo9.FillInfo(closeDryingShiberCommand, messageSourceIsDrying, positiveStatus);
    }

    public void SetDryingShiberIsClosed()
    {
        messageInfoOnMnemo9.FillInfo(dryingShiberIsClosed, messageSourceIsDrying, positiveStatus);
    }

    public void StartDrying()
    {
        messageInfoOnMnemo9.FillInfo(startDryingCommand, messageSourceIsDrying, positiveStatus);
    }

    public void SetDryingIsFinished()
    {
        messageInfoOnMnemo9.FillInfo(dryingIsFinished, messageSourceIsDrying, positiveStatus);
    }
}
