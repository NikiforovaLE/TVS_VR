using UnityEngine;

public class Mnemo6Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo6;

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string getTransportContainerCommand = "������ ������� \"������ ������������ ���� � ��������� ��� � ������� � ������������ �������\"";
    private readonly string transportContainerIsRecieved = "������ ������������ ���� � ��������� ��� � �������";

    private readonly string messageSourceIsAssembly = "������ ���";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiber()
    {
        messageInfoOnMnemo6.FillInfo(openShiberCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo6.FillInfo(closeShiberCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo6.FillInfo(shiberIsOpened, messageSourceIsAssembly, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo6.FillInfo(shiberIsClosed, messageSourceIsAssembly, positiveStatus);
    }
    
    public void GetTransportContainer()
    {
        messageInfoOnMnemo6.FillInfo(getTransportContainerCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetTransportContainerIsRecieved()
    {
        messageInfoOnMnemo6.FillInfo(transportContainerIsRecieved, messageSourceIsAssembly, positiveStatus);
    }
}
