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

    private readonly string messageSourceIsAssembly = "Сборка ТВС";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
}
