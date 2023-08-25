using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo3Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo3;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string getVtukCommand = "Выдана команда \"Получить ВТУК\"";
    private readonly string vtukIsReceived = "Получен ВТУК";

    private readonly string extractFuelRodCommand = "Выдана команда \"Извлечь твэл\"";
    private readonly string fuelRodIsExtracted = "Извлечён твэл из магазина";
    private readonly string readFuelRodNumberCommand = "Выдана команда \"Считать номер твэла\"";
    private readonly string fuelNumberIsRead = "Считан номер твэла ";
    private readonly string transferFuelRodForAssemblyCommand = "Выдана команда \"Передать твэл на сборку\"";
    private readonly string FuelRodIsTransfered = "Твэл перемещён на сборку ТВС";
    private readonly string returnMagazineCommand = "Выдана команда \"Вернуть магазин\"";
    private readonly string magazineIsPlacedInVtuk = "\"Магазин помещён во ВТУК\"";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsVtuk = "Работа с ВТУК";
    private readonly string messageSourceIsFuelRods = "Работа с твэлами";

    public void OpenShiber()
    {
        messageInfoOnMnemo3.FillInfo(openShiberCommand, messageSourceIsVtuk, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo3.FillInfo(closeShiberCommand, messageSourceIsVtuk, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo3.FillInfo(shiberIsOpened, messageSourceIsVtuk, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo3.FillInfo(shiberIsClosed, messageSourceIsVtuk, positiveStatus);
    }

    public void GetVtuk()
    {
        messageInfoOnMnemo3.FillInfo(getVtukCommand, messageSourceIsVtuk, positiveStatus);
    }

    public void SetVtukIsRecieved()
    {
        messageInfoOnMnemo3.FillInfo(vtukIsReceived, messageSourceIsVtuk, positiveStatus);
    }    
    
    public void ExtractFuelRod()
    {
        messageInfoOnMnemo3.FillInfo(extractFuelRodCommand, messageSourceIsFuelRods, positiveStatus);
    }

    public void SetFuelRodIsExtracted()
    {
        messageInfoOnMnemo3.FillInfo(fuelRodIsExtracted, messageSourceIsFuelRods, positiveStatus);
    }    
    
    public void ReadFuelRodNumber()
    {
        messageInfoOnMnemo3.FillInfo(readFuelRodNumberCommand, messageSourceIsFuelRods, positiveStatus);
    }    
    
    public void SetFuelRodNumberIsRead()
    {
        messageInfoOnMnemo3.FillInfo(fuelNumberIsRead, messageSourceIsFuelRods, positiveStatus);
    }

    public void TransferFuelRodForAssembly()
    {
        messageInfoOnMnemo3.FillInfo(transferFuelRodForAssemblyCommand, messageSourceIsFuelRods, positiveStatus);
    }

    public void SetFuelRodIsTransfered()
    {
        messageInfoOnMnemo3.FillInfo(FuelRodIsTransfered, messageSourceIsFuelRods, positiveStatus);
    }
    
    public void ReturnMagazine()
    {
        messageInfoOnMnemo3.FillInfo(returnMagazineCommand, messageSourceIsVtuk, positiveStatus);
    }

    public void SetMagazineIsPlacedInVtuk()
    {
        messageInfoOnMnemo3.FillInfo(magazineIsPlacedInVtuk, messageSourceIsVtuk, positiveStatus);
    }
}
