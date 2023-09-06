using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo12Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo12;

    private readonly string performControlCommand = "������ ������� \"��������� ��������\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string testIsPerformed = "�������� ������������� ������������� ��������";

    private readonly string messageSourceIsWeightControl = "�������� ����� ���, ���������� ��� � �������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void PerformControl()
    {
        messageInfoOnMnemo12.FillInfo(performControlCommand, messageSourceIsWeightControl, positiveStatus);
    }
}
