using UnityEngine;

public class Mnemo14Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo14;

    private readonly string openShiberCommand = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommand = "������ ������� \"������� �����\"";
    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";

    private readonly string removeBoxRootCommand = "������ ������� \"����� ������ ������\"";
    private readonly string boxRootIsRemoved = "������ ������ �����";

    private readonly string messageSourceIs = "����� ������";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(openShiberCommand, messageSourceIs, positiveStatus);
    }

    public void CloseShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(closeShiberCommand, messageSourceIs, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsOpened, messageSourceIs, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsClosed, messageSourceIs, positiveStatus);
    }
}
