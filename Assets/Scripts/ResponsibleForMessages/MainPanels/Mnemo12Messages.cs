using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo12Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo12;

    private readonly string performControlCommand = "Выдана команда \"Выполнить проверку\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string testIsPerformed = "Контроль поверхностной загрязнённости завершён";

    private readonly string messageSourceIsWeightControl = "Контроль массы ТВС, входимости ТВС в стапель";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void PerformControl()
    {
        messageInfoOnMnemo12.FillInfo(performControlCommand, messageSourceIsWeightControl, positiveStatus);
    }
}
