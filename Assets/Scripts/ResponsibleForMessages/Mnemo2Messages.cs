using UnityEngine;

public class Mnemo2Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo2;

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
    public void OpenShiber()
    {
        messageInfoOnMnemo2.FillInfo(openShiberCommand, positiveStatus);
    }

    public void CloseShiber()
    {
        messageInfoOnMnemo2.FillInfo(closeShiberCommand, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsOpened, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsClosed, positiveStatus);
    }
}
