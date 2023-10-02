using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo16Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo16;

    private readonly string removeEmptyBoxCommand = "Выдана команда \"Извлечь порожний пенал из транспортной тележки\"";
    private readonly string moveCoordinateManipulatorToTransferCarCommand = "Выдана команда \"Переместить КМ в зону \"Тележка передаточная\"\"";
    private readonly string loadBoxIntoTransferCarCommand = "Выдана команда \"Загрузить порожний пенал в тележку передаточную\"";
    private readonly string removeBoxFromTransportCarCommand = "Выдана команда \"Извлечь пенал с ТВС из тележки передаточной\"";

    private readonly string emptyBoxIsRemoved = "Порожний пенал извлечён из транспортной тележки";
    private readonly string emptyBoxIsLoaded = "Порожний пенал загружен в тележку передаточную";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    private readonly string messageSourceIsEmptyBoxTransportation = "Транспортировка порожнего пенала";

    public void RemoveEmptyBoxCommand()
    {
        messageInfoOnMnemo16.FillInfo(removeEmptyBoxCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }

    public void MoveCoordinateManipulatorToTransferCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(moveCoordinateManipulatorToTransferCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }

    public void LoadBoxIntoTransferCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(loadBoxIntoTransferCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void RemoveBoxFromTransportCarCommand()
    {
        messageInfoOnMnemo16.FillInfo(removeBoxFromTransportCarCommand, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void SetEmptyBoxIsRemoved()
    {
        messageInfoOnMnemo16.FillInfo(emptyBoxIsRemoved, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
    
    public void SetEmptyBoxIsLoaded()
    {
        messageInfoOnMnemo16.FillInfo(emptyBoxIsLoaded, messageSourceIsEmptyBoxTransportation, positiveStatus);
    }
}
