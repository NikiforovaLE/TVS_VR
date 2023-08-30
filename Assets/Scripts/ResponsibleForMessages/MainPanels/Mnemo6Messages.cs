using UnityEngine;

public class Mnemo6Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo6;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string getTransportContainerCommand = "Выдана команда \"Подать транспортную тару с головками ТВС и гайками в локализующее укрытие\"";
    private readonly string transportContainerIsRecieved = "Подана транспортная тара с головками ТВС и гайками";

    private readonly string messageSourceIsAssembly = "Сборка ТВС";

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
