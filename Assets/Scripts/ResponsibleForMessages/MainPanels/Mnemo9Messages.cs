using UnityEngine;

public class Mnemo9Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo9;

    private readonly string openWashingShiberCommand = "Выдана команда \"Открыть шибер реторты отмывки\"";
    private readonly string closeWashingShiberCommand = "Выдана команда \"Закрыть шибер реторты отмывки\"";

    private readonly string washingShiberIsOpened = "Шибер реторты отмывки открыт";
    private readonly string washingShiberIsClosed = "Шибер реторты отмывки закрыт";

    private readonly string openDryingShiberCommand = "Выдана команда \"Открыть шибер реторты сушки\"";
    private readonly string closeDryingShiberCommand = "Выдана команда \"Закрыть шибер реторты сушки\"";

    private readonly string dryingShiberIsOpened = "Шибер реторты сушки открыт";
    private readonly string dryingShiberIsClosed = "Шибер реторты сушки закрыт";

    private readonly string startWashingCommand = "Выдана команда \"Начать отмывку\"";
    private readonly string startDryingCommand = "Выдана команда \"Начать сушку\"";

    private readonly string washingIsFinished = "Отмывка завершена";
    private readonly string dryingIsFinished = "Сушка завершена";

    private readonly string messageSourceIsWashing = "Отмывка";
    private readonly string messageSourceIsDrying = "Сушка";

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
