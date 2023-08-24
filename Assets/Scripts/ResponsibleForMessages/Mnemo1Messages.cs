using UnityEngine;

public class Mnemo1Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo1;

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string moveIntoShelterCommand = "������ ������� \"������ �� � �������\"";
    private readonly string lodgementIsInShelter = "��������-��������� ����� � �������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSource = "������ ���";

    public void OpenShiber()
    {
        messageInfoOnMnemo1.FillInfo(openShiberCommand, messageSource, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo1.FillInfo(closeShiberCommand, messageSource, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo1.FillInfo(shiberIsOpened, messageSource, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo1.FillInfo(shiberIsClosed, messageSource, positiveStatus);
    }

    public void MoveIntoShelter()
    {
        messageInfoOnMnemo1.FillInfo(moveIntoShelterCommand, messageSource, positiveStatus);
    }

    public void SetLodgementIsInShelter()
    {
        messageInfoOnMnemo1.FillInfo(lodgementIsInShelter, messageSource, positiveStatus);
    }
}
