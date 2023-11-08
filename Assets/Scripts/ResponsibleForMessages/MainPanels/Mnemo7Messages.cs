using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo7Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo7;

    private readonly string transferLodgementToVerticalPositionCommand = "������ ������� \"��������� ��������-��������� � ������������ ���������\"";
    private readonly string lodgementIsInoVerticalPosition = "��������-��������� � ������������ ���������";

    private readonly string getTvsHeadCommand = "������ ������� \"�������� ���� � ������� � �������� ���\"";
    private readonly string tvsHeadIsGot = "���� � ������� � �������� ��������";

    private readonly string installHeadOnTvsFrameCommand = "������ ������� \"���������� ������� �� ������� ���\"";
    private readonly string tightenHeadOnTvsFrameCommand = "������ ������� \"������� ������� �� ������� ���\"";

    private readonly string headIsInstalled = "����������� ������� �� ������� ���";
    private readonly string headIsTighten = "������� ������� �� ������� ���";

    private readonly string retainerIsTighten = "�������� ������� ��� ������";
    private readonly string retainerIsNotTighten = "�������� ������� ��� �� ������";

    private readonly string messageSourceIsAssembly = "������ ���";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void TransferToVerticalPositionCommand()
    {
        messageInfoOnMnemo7.FillInfo(transferLodgementToVerticalPositionCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetLodgementIsInoVerticalPosition()
    {
        messageInfoOnMnemo7.FillInfo(lodgementIsInoVerticalPosition, messageSourceIsAssembly, positiveStatus);
    }

    public void GetTvsHeadCommand()
    {
        messageInfoOnMnemo7.FillInfo(getTvsHeadCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetTvsHeadIsGot()
    {
        messageInfoOnMnemo7.FillInfo(tvsHeadIsGot, messageSourceIsAssembly, positiveStatus);
    }

    public void InstallHeadOnTvsFrameCommand()
    {
        messageInfoOnMnemo7.FillInfo(installHeadOnTvsFrameCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void TightenHeadOnTvsFrameCommand()
    {
        messageInfoOnMnemo7.FillInfo(tightenHeadOnTvsFrameCommand, messageSourceIsAssembly, positiveStatus);
    }

    public void SetHeadIsInstalled()
    {
        messageInfoOnMnemo7.FillInfo(headIsInstalled, messageSourceIsAssembly, positiveStatus);
    }

    public void SetHeadIsTighten()
    {
        messageInfoOnMnemo7.FillInfo(headIsTighten, messageSourceIsAssembly, positiveStatus);
    }

    public void SetRetainerIsTighten()
    {
        messageInfoOnMnemo7.FillInfo(retainerIsTighten, messageSourceIsAssembly, positiveStatus);
    }

    public void SetRetainerIsNotTighten()
    {
        messageInfoOnMnemo7.FillInfo(retainerIsNotTighten, messageSourceIsAssembly, positiveStatus);
    }
}
