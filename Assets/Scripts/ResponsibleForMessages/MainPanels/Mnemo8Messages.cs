using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo8Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo8;

    private readonly string moveTvsToWashingCommand = "Выдана команда \"Переместить ТВС в зону \"отмывка\"\"";
    private readonly string moveTvsToDryingCommand = "Выдана команда \"Переместить ТВС в зону \"сушка\"\"";
    private readonly string moveTvsToTightnessControlCommand = "Выдана команда \"Переместить ТВС в зону \"герметичность\"\"";
    private readonly string moveTvsToImpurityControlCommand = "Выдана команда \"Переместить ТВС в зону \"загрязнённость\"\"";
    private readonly string moveTvsToWeightControlCommand = "Выдана команда \"Переместить ТВС в зону \"масса, входимость\"\"";
    private readonly string moveTvsToGeometryControlCommand = "Выдана команда \"Переместить ТВС в зону \"геометрия\"\"";

    private readonly string openWashRetortCommand = "Выдана команда \"Открыть крышку реторты отмывки\"";
    private readonly string openDryingRetortCommand = "Выдана команда \"Открыть крышку реторты сушки\"";
    private readonly string openTightnessRetortCommand = "Выдана команда \"Открыть крышку реторты герметичности\"";

    private readonly string washRetortIsOpened = "Крышка реторты отмывки открыта";
    private readonly string dryingRetortIsOpened = "Крышка реторты сушки открыта";
    private readonly string tightnessRetortIsOpened = "Крышка реторты герметичности открыта";

    private readonly string closeWashRetortCommand = "Выдана команда \"Закрыть крышку реторты отмывки\"";
    private readonly string closeDryingRetortCommand = "Выдана команда \"Закрыть крышку реторты сушки\"";
    private readonly string closeTightnessRetortCommand = "Выдана команда \"Закрыть крышку реторты герметичности\"";

    private readonly string washRetortIsClosed = "Крышка реторты отмывки закрыта";
    private readonly string dryingRetortIsClosed = "Крышка реторты сушки закрыта";
    private readonly string tightnessRetortIsClosed = "Крышка реторты герметичности закрыта";

    private readonly string messageSourceIsCoordinateManipulator = "Координатный некопирующий манипулятор";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    public void MoveTvsToWashingCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToWashingCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }

    public void MoveTvsToDryingCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToDryingCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToTightnessControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToTightnessControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToImpurityControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToImpurityControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToWeightControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToWeightControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void MoveTvsToGeometryControlCommand()
    {
        messageInfoOnMnemo8.FillInfo(moveTvsToGeometryControlCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenWashRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openWashRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenDryingRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openDryingRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void OpenTightnessRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(openTightnessRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetWashRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(washRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetDryingRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(dryingRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetTightnessRetortIsOpened()
    {
        messageInfoOnMnemo8.FillInfo(tightnessRetortIsOpened, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseWashRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeWashRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseDryingRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeDryingRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void CloseTightnessRetortCommand()
    {
        messageInfoOnMnemo8.FillInfo(closeTightnessRetortCommand, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetWashRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(washRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetDryingRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(dryingRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
    
    public void SetTightnessRetortIsClosed()
    {
        messageInfoOnMnemo8.FillInfo(tightnessRetortIsClosed, messageSourceIsCoordinateManipulator, positiveStatus);
    }
}
