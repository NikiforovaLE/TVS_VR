using UnityEngine;

public class Mnemo15Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo15;

    private readonly string moveTransportCarToManipulatorCranZoneCommand = "������ ������� \"����������� ������� ������������ � ���� \"����-�����������\"\"";
    private readonly string moveTransportCarToBoxLidRemovingZoneCommand = "������ ������� \"����������� ������� ������������ � ���� \"������ ������ ������\"\"";
    private readonly string moveTransportCarToCoordinateManipulatorZoneCommand = "������ ������� \"����������� ������� ������������ � ���� \"������������ �����������\"\"";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsEmptyBoxTransportation = "��������������� ��������� ������";
    private readonly string messageSourceIsBoxedTvsTransportation = "��������������� ������������ ���";
    public void MoveTransportCarToManipulatorCranZoneCommand()
    {
        messageInfoOnMnemo15.FillInfo(moveTransportCarToManipulatorCranZoneCommand, messageSourceIsBoxedTvsTransportation, positiveStatus);
    }
    
    public void MoveTransportCarToBoxLidRemovingZoneCommand()
    {
        messageInfoOnMnemo15.FillInfo(moveTransportCarToBoxLidRemovingZoneCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void MoveTransportCarToCoordinateManipulatorZoneCommand()
    {
        messageInfoOnMnemo15.FillInfo(moveTransportCarToCoordinateManipulatorZoneCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
}
