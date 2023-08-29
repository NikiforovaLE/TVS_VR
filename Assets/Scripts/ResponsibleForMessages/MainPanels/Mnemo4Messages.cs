using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo4Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo4;
    [SerializeField] private Mnemo04Animation mnemo04Animation;

    private readonly string readFuelRodNumberCommand = "Выдана команда \"Считать номер твэла\"";
    private readonly string fuelNumberIsRead = "Считан номер твэла ";
    private readonly string transferFuelRodForAssemblyCommand = "Выдана команда \"Передать твэл на сборку\"";
    private readonly string fuelRodIsTransferedForAssembly = "Твэл перемещён на сборку";
    private readonly string removeFuelRodCommand = "Выдана команда \"Извлечь твэл\"";
    private readonly string fuelRodIsRemovedFromMagazine = "Извлечён твэл из магазина\"";
    private readonly string returnMagazineCommand = "Выдана команда \"Вернуть магазин\"";
    private readonly string magazineIsPlacedInVtuk = "Магазин помещён во ВТУК";

    private readonly string messageSourceIsVtuk = "Работа с ВТУК";
    private readonly string messageSourceIsFuelRods = "Работа с твэлами";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void ReadFuelRodNumber()
    {
        messageInfoOnMnemo4.FillInfo(readFuelRodNumberCommand, messageSourceIsFuelRods, positiveStatus);
    }

    public void SetFuelNumberIsRead()
    {
        messageInfoOnMnemo4.FillInfo(fuelNumberIsRead + mnemo04Animation.CurrentFuelRodNumberText.text, messageSourceIsFuelRods, positiveStatus);
    }

    public void TransferFuelRodForAssembly()
    {
        messageInfoOnMnemo4.FillInfo(transferFuelRodForAssemblyCommand, messageSourceIsFuelRods, positiveStatus);
    }    
    
    public void SetFuelRodIsTransferedForAssembly()
    {
        messageInfoOnMnemo4.FillInfo(fuelRodIsTransferedForAssembly, messageSourceIsFuelRods, positiveStatus);
    }
    
    public void RemoveFuelRod()
    {
        messageInfoOnMnemo4.FillInfo(removeFuelRodCommand, messageSourceIsFuelRods, positiveStatus);
    }
    
    public void SetFuelRodIsRemovedFromMagazine()
    {
        messageInfoOnMnemo4.FillInfo(fuelRodIsRemovedFromMagazine, messageSourceIsFuelRods, positiveStatus);
    }
    public void ReturnMagazine()
    {
        messageInfoOnMnemo4.FillInfo(returnMagazineCommand, messageSourceIsVtuk, positiveStatus);
    }

    public void SetMagazineIsPlacedInVtuk()
    {
        messageInfoOnMnemo4.FillInfo(magazineIsPlacedInVtuk, messageSourceIsVtuk, positiveStatus);
    }
}
