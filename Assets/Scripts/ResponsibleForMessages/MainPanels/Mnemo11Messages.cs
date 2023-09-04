using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo11Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo11;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string testIsPerformed = "Контроль поверхностной загрязнённости завершён";

    private readonly string messageSourceIsImpurityControl = "Контроль поверхностной загрязнённости";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiber()
    {
        messageInfoOnMnemo11.FillInfo(openShiberCommand, messageSourceIsImpurityControl, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo11.FillInfo(shiberIsOpened, messageSourceIsImpurityControl, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo11.FillInfo(closeShiberCommand, messageSourceIsImpurityControl, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo11.FillInfo(shiberIsClosed, messageSourceIsImpurityControl, positiveStatus);
    }

    public void SetTestIsPerformed()
    {
        messageInfoOnMnemo11.FillInfo(testIsPerformed, messageSourceIsImpurityControl, positiveStatus);
    }
}
