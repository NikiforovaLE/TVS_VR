using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo8Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo8;

    private readonly string moveTvsToWashingCommand = "������ ������� \"����������� ��� � ���� \"�������\"\"";
    private readonly string moveTvsToDryingCommand = "������ ������� \"����������� ��� � ���� \"�����\"\"";
    private readonly string moveTvsToTightnessControlCommand = "������ ������� \"����������� ��� � ���� \"�������������\"\"";
    private readonly string moveTvsToImpurityControlCommand = "������ ������� \"����������� ��� � ���� \"�������������\"\"";
    private readonly string moveTvsToWeightControlCommand = "������ ������� \"����������� ��� � ���� \"�����, ����������\"\"";
    private readonly string moveTvsToGeometryControlCommand = "������ ������� \"����������� ��� � ���� \"���������\"\"";

    private readonly string openWashRetortCommand = "������ ������� \"������� ������ ������� �������\"";
    private readonly string openDryingRetortCommand = "������ ������� \"������� ������ ������� �����\"";
    private readonly string openTightnessRetortCommand = "������ ������� \"������� ������ ������� �������������\"";

    private readonly string washRetortIsOpened = "������ ������� ������� �������";
    private readonly string dryingRetortIsOpened = "������ ������� ����� �������";
    private readonly string tightnessRetortIsOpened = "������ ������� ������������� �������";

    private readonly string closeWashRetortCommand = "������ ������� \"������� ������ ������� �������\"";
    private readonly string closeDryingRetortCommand = "������ ������� \"������� ������ ������� �����\"";
    private readonly string closeTightnessRetortCommand = "������ ������� \"������� ������ ������� �������������\"";

    private readonly string washRetortIsClosed = "������ ������� ������� �������";
    private readonly string dryingRetortIsClosed = "������ ������� ����� �������";
    private readonly string tightnessRetortIsClosed = "������ ������� ������������� �������";

    private readonly string messageSourceIsAssembly = "������ ���";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
}
