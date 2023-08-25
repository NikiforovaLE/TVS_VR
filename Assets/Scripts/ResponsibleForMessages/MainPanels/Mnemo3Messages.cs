using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo3Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo3;

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string getVtukCommand = "������ ������� \"�������� ����\"";
    private readonly string vtukIsReceived = "������� ����";

    private readonly string extractFuelRodCommand = "������ ������� \"������� ����\"";
    private readonly string fuelRodIsExtracted = "�������� ���� �� ��������";
    private readonly string readFuelRodNumberCommand = "������ ������� \"������� ����� �����\"";
    private readonly string fuelNumberIsRead = "������ ����� ����� ";
    private readonly string transferFuelRodForAssemblyCommand = "������ ������� \"�������� ���� �� ������\"";
    private readonly string FuelRodIsTransfered = "���� ��������� �� ������ ���";
    private readonly string returnMagazineCommand = "������ ������� \"������� �������\"";
    private readonly string magazineIsPlacedInVtuk = "\"������� ������� �� ����\"";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsVtuk = "������ � ����";
    private readonly string messageSourceIsFuelRods = "������ � �������";

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
