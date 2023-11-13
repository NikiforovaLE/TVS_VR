using UnityEngine;

public class Mnemo12Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo12;

    private readonly string performControlCommand = "Выдана команда \"Выполнить проверку\"";

    private readonly string weightControlIsPerformed = "Контроль веса завершён";
    private readonly string entranceToSlipwayControlIsPerformed = "Контроль входимости в стапель завершён";
    private readonly string shankLockControlIsPerformed = "Контроль замка хвостовика завершён";
    private readonly string suzControlIsPerformed = "Контроль СУЗ завершён";

    private readonly string messageSourceIsWeightControl = "Контроль массы ТВС, входимости ТВС в стапель";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void PerformControlCommand()
    {
        messageInfoOnMnemo12.FillInfo(performControlCommand, messageSourceIsWeightControl, positiveStatus);
    }

    public void SetWeightControlIsPerformed()
    {
        messageInfoOnMnemo12.FillInfo(weightControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
    
    public void SetEntranceToSlipwayControlIsPerformed()
    {
        messageInfoOnMnemo12.FillInfo(entranceToSlipwayControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
    
    public void SetShankLockControlIsPerformed()
    {
        messageInfoOnMnemo12.FillInfo(shankLockControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
    
    public void SetSuzControlIsPerformed()
    {
        messageInfoOnMnemo12.FillInfo(suzControlIsPerformed, messageSourceIsWeightControl, positiveStatus);
    }
}
