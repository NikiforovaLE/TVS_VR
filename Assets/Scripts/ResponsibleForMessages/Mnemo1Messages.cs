using UnityEngine;

public class Mnemo1Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo1;

    private readonly string openShiberCommand = "Выдана команда \"Открыть шибер\"";
    private readonly string closeShiberCommand = "Выдана команда \"Закрыть шибер\"";

    private readonly string shiberIsOpened = "Шибер открыт";
    private readonly string shiberIsClosed = "Шибер закрыт";

    private readonly string moveIntoShelterCommand = "Выдана команда \"Подать ЛС в укрытие\"";
    private readonly string lodgementIsInShelter = "Ложемент-свидетель подан в укрытие";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
    public void OpenShiber()
    {
        messageInfoOnMnemo1.FillInfo(openShiberCommand, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo1.FillInfo(closeShiberCommand, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo1.FillInfo(shiberIsOpened, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo1.FillInfo(shiberIsClosed, positiveStatus);
    }

    public void MoveIntoShelter()
    {
        messageInfoOnMnemo1.FillInfo(moveIntoShelterCommand, positiveStatus);
    }

    public void SetLodgementIsInShelter()
    {
        messageInfoOnMnemo1.FillInfo(lodgementIsInShelter, positiveStatus);
    }
}
