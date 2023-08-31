using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo7Messages : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo7;

    private readonly string transferLodgementToVerticalPositionCommand = "Выдана команда \"Перевести ложемент-свидетель в вертикальное положение\"";

    private readonly string installHeadOnTvsFrame = "Выдана команда \"Установить головку на каркасе ТВС\"";
    private readonly string tightenHeadOnTvsFrame = "Выдана команда \"Поджать головку на каркасе ТВС\"";

    private readonly string headIsInstalled = "Установлена головка на каркасе ТВС";
    private readonly string headIsTighten = "Поджата головка на каркасе ТВС";

    private readonly string retainerIsTighten = "Фиксатор головки ТВС поджат";
    private readonly string retainerIsNotTighten = "Фиксатор головки ТВС не поджат";
    private readonly string lodgementIsInoVerticalPosition = "Ложемент-свидетель в вертикальном положении";

    private readonly string messageSourceIsAssembly = "Сборка ТВС";

    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";
}
