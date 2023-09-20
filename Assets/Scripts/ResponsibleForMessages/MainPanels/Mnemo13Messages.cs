using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo13Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo13;

    private readonly string performControlCommand = "������ ������� \"��������� ��������\"";

    private readonly string tvsLengthControlIsPerformed = "�������� �� ����� ��� ��������";
    private readonly string sizeControlIsPerformed = "�������� �� ������� ��� ���� ��������";
    private readonly string appearanceControlIsPerformed = "�������� �� �������� ���� ��������";

    private readonly string messageSourceIsWeightControl = "�������� ����� ���";
    private readonly string messageSourceIsEntryControl = "�������� ���������� ��� � �������";

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
