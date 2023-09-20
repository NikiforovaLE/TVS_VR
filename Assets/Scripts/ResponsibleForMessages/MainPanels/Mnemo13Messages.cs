using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo13Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo13;

    private readonly string performControlCommand = "Выдана команда \"Выполнить проверку\"";

    private readonly string tvsLengthControlIsPerformed = "Контроль по длине ТВС выполнен";
    private readonly string sizeControlIsPerformed = "Контроль по размеру под ключ выполнен";
    private readonly string appearanceControlIsPerformed = "Контроль по внешнему виду выполнен";

    private readonly string messageSourceIsWeightControl = "Контроль массы ТВС";
    private readonly string messageSourceIsEntryControl = "Контроль входимости ТВС в стапель";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void PerformControl()
    {
        messageInfoOnMnemo13.FillInfo(performControlCommand, messageSourceIsWeightControl, positiveStatus);
    }

    public void TvsLengthControlIsPerformed()
    {
        messageInfoOnMnemo13.FillInfo(tvsLengthControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
    
    public void TvsSizeControlIsPerformed()
    {
        messageInfoOnMnemo13.FillInfo(sizeControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
    
    public void TvsAppearanceControlIsPerformed()
    {
        messageInfoOnMnemo13.FillInfo(appearanceControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
}
