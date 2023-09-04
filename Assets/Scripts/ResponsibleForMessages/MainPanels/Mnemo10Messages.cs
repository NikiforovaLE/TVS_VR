using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo10Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo10;

    private readonly string starSensitivityTestCommand = "������ ������� \"��������� �������� ���������������� �������\"";

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string testIsPerformed = "�������� ���������";

    private readonly string messageSourceIsTightnessControl = "�������� �������������";

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
