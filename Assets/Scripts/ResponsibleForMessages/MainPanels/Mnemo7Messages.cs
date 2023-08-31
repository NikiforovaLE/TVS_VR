using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo7Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo7;

    private readonly string transferLodgementToVerticalPositionCommand = "������ ������� \"��������� ��������-��������� � ������������ ���������\"";

    private readonly string installHeadOnTvsFrame = "������ ������� \"���������� ������� �� ������� ���\"";
    private readonly string tightenHeadOnTvsFrame = "������ ������� \"������� ������� �� ������� ���\"";

    private readonly string headIsInstalled = "����������� ������� �� ������� ���";
    private readonly string headIsTighten = "������� ������� �� ������� ���";

    private readonly string retainerIsTighten = "�������� ������� ��� ������";
    private readonly string retainerIsNotTighten = "�������� ������� ��� �� ������";
    private readonly string lodgementIsInoVerticalPosition = "��������-��������� � ������������ ���������";

    private readonly string messageSourceIsAssembly = "������ ���";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
}
