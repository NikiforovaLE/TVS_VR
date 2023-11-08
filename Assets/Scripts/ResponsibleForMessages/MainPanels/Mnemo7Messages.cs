using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo7Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo7;

    private readonly string transferLodgementToVerticalPositionCommand = "Выдана команда \"Перевести ложемент-свидетель в вертикальное положение\"";
    private readonly string lodgementIsInoVerticalPosition = "Ложемент-свидетель в вертикальном положении";

    private readonly string getTvsHeadCommand = "Выдана команда \"Получить тару с гайками и головкой ТВС\"";
    private readonly string tvsHeadIsGot = "Тара с гайками и головкой получена";

    private readonly string installHeadOnTvsFrameCommand = "Выдана команда \"Установить головку на каркасе ТВС\"";
    private readonly string tightenHeadOnTvsFrameCommand = "Выдана команда \"Поджать головку на каркасе ТВС\"";

    private readonly string headIsInstalled = "Установлена головка на каркасе ТВС";
    private readonly string headIsTighten = "Поджата головка на каркасе ТВС";

    private readonly string retainerIsTighten = "Фиксатор головки ТВС поджат";
    private readonly string retainerIsNotTighten = "Фиксатор головки ТВС не поджат";

    private readonly string messageSourceIsAssembly = "Сборка ТВС";

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
