using UnityEngine;

public class Mnemo14Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo14;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";
    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string removeBoxRootCommand = "Выдана команда \"Снять крышку пенала\"";
    private readonly string boxRootIsRemoved = "Крышка пенала снята";

    private readonly string messageSourceIsBoxLoading = "Загрузка в пенал";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(openShiberCommand, messageSourceIsBoxLoading, positiveStatus);
    }

    public void CloseShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(closeShiberCommand, messageSourceIsBoxLoading, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsOpened, messageSourceIsBoxLoading, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsClosed, messageSourceIsBoxLoading, positiveStatus);
    }
    
    public void RemoveBoxRootCommand()
    {
        messageInfoOnMnemo14.FillInfo(removeBoxRootCommand, messageSourceIsBoxLoading, positiveStatus);
    }
    
    public void SetBoxRootIsRemoved()
    {
        messageInfoOnMnemo14.FillInfo(boxRootIsRemoved, messageSourceIsBoxLoading, positiveStatus);
    }
}
