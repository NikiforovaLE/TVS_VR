using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo10Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo10;

    private readonly string starSensitivityTestCommand = "Выдана команда \"Выполнить проверку чувствительности системы\"";

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string testIsPerformed = "Проверка выполнена";

    private readonly string messageSourceIsTightnessControl = "Контроль герметичности";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiber()
    {
        messageInfoOnMnemo10.FillInfo(openShiberCommand, messageSourceIsTightnessControl, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo10.FillInfo(shiberIsOpened, messageSourceIsTightnessControl, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo10.FillInfo(closeShiberCommand, messageSourceIsTightnessControl, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo10.FillInfo(shiberIsClosed, messageSourceIsTightnessControl, positiveStatus);
    }

    public void StartSensitivityTest()
    {
        messageInfoOnMnemo10.FillInfo(starSensitivityTestCommand, messageSourceIsTightnessControl, positiveStatus);
    }

    public void SetTestIsPerformed()
    {
        messageInfoOnMnemo10.FillInfo(testIsPerformed, messageSourceIsTightnessControl, positiveStatus);
    }
}
