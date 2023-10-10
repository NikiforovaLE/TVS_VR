using UnityEngine;

public class Mnemo15Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo15;

    private readonly string moveTransportCarToManipulatorCranZoneCommand = "Выдана команда \"Переместить тележку передаточную в зону \"Кран-манипулятор\"\"";
    private readonly string moveTransportCarToBoxLidRemovingZoneCommand = "Выдана команда \"Переместить тележку передаточную в зону \"Снятие крышки пенала\"\"";
    private readonly string moveTransportCarToCoordinateManipulatorZoneCommand = "Выдана команда \"Переместить тележку передаточную в зону \"Координатный манипулятор\"\"";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsEmptyBoxTransportation = "Транспортировка порожнего пенала";
    private readonly string messageSourceIsBoxedTvsTransportation = "Транспортировка запеналенной ТВС";
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
