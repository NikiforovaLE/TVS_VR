using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo4Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo4;
    [SerializeField] private Mnemo04Animation mnemo04Animation;

    private readonly string readFuelRodNumberCommand = "������ ������� \"������� ����� �����\"";
    private readonly string fuelNumberIsRead = "������ ����� ����� ";
    private readonly string transferFuelRodForAssemblyCommand = "������ ������� \"�������� ���� �� ������\"";
    private readonly string fuelRodIsTransferedForAssembly = "���� ��������� �� ������";
    private readonly string removeFuelRodCommand = "������ ������� \"������� ����\"";
    private readonly string fuelRodIsRemovedFromMagazine = "�������� ���� �� ��������\"";
    private readonly string returnMagazineCommand = "������ ������� \"������� �������\"";
    private readonly string magazineIsPlacedInVtuk = "������� ������� �� ����";

    private readonly string messageSourceIsVtuk = "������ � ����";
    private readonly string messageSourceIsFuelRods = "������ � �������";

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
