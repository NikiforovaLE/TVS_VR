using UnityEngine;

public class Mnemo2Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo2;

    private readonly string openShiberCommandText = "������ ������� \"������� �����\"";
    private readonly string closeShiberCommandText = "������ ������� \"������� �����\"";
    private readonly string giveVtukCommandText = "������ ������� \"������ ����\"";

    private readonly string shiberIsOpened = "����� ������";
    private readonly string shiberIsClosed = "����� ������";
    private readonly string vtukIsGiven = "���� �����";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSource = "������ � ����";
    public void OpenShiberCommamd()
    {
        messageInfoOnMnemo2.FillInfo(openShiberCommandText, messageSource, positiveStatus);
    }

    public void CloseShiberCommamd()
    {
        messageInfoOnMnemo2.FillInfo(closeShiberCommandText, messageSource, positiveStatus);
    }
    
    public void GiveVtukCommand()
    {
        messageInfoOnMnemo2.FillInfo(giveVtukCommandText, messageSource, positiveStatus);
    }

    public void SetShiberIsOpened()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsOpened, messageSource, positiveStatus);
    }

    public void SetShiberIsClosed()
    {
        messageInfoOnMnemo2.FillInfo(shiberIsClosed, messageSource, positiveStatus);
    }
    
    public void SetVtukIsGiven()
    {
        messageInfoOnMnemo2.FillInfo(vtukIsGiven, messageSource, positiveStatus);
    }
}
