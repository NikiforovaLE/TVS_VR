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

    private readonly string messageSourceIsBoxLoading = "�������� � �����";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void OpenShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(openShiberCommand, messageSourceIsBoxLoading, positiveStatus);
    }

    public void CloseShiberCommand()
    {
        messageInfoOnMnemo14.FillInfo(closeShiberCommand, messageSourceIsBoxLoading, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsOpened, messageSourceIsBoxLoading, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo14.FillInfo(shiberIsClosed, messageSourceIsBoxLoading, positiveStatus);
    }
    
    public void RemoveBoxRootCommand()
    {
        messageInfoOnMnemo14.FillInfo(removeBoxRootCommand, messageSourceIsBoxLoading, positiveStatus);
    }
    
    public void SetBoxRootIsRemoved()
    {
        messageInfoOnMnemo14.FillInfo(boxRootIsRemoved, messageSourceIsBoxLoading, positiveStatus);
    }
}
