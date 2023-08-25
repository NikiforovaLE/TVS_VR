using UnityEngine;

public class Mnemo2Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo2;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSource = "Работа с ВТУК";
    public void OpenShiber()
    {
        messageInfoOnMnemo2.FillInfo(openShiberCommand, messageSource, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo2.FillInfo(closeShiberCommand, messageSource, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsOpened, messageSource, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsClosed, messageSource, positiveStatus);
    }
}
