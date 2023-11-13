using UnityEngine;

public class Mnemo12Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo12;

    private readonly string performControlCommand = "������ ������� \"��������� ��������\"";

    private readonly string weightControlIsPerformed = "�������� ���� ��������";
    private readonly string entranceToSlipwayControlIsPerformed = "�������� ���������� � ������� ��������";
    private readonly string shankLockControlIsPerformed = "�������� ����� ���������� ��������";
    private readonly string suzControlIsPerformed = "�������� ��� ��������";

    private readonly string messageSourceIsWeightControl = "�������� ����� ���, ���������� ��� � �������";

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
