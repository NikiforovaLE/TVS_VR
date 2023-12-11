using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo3 : MonoBehaviour
{
    [SerializeField] private ARMPanelActions ARM2PanelActions;
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;
    [SerializeField] private ARM2Mnemo2 ARM2Mnemo2;
    [SerializeField] private GameObject mainMnemoARM2;
    [SerializeField] private Text outputVTUKNumber;
    [SerializeField] private Text infoAboutVTUKNumberOn02Mnemo;
    [SerializeField] private Text ARM2Mnemo2TextAboutVTUKNumber;
    [SerializeField] private Text ARM2Mnemo2TextAboutAmountOfFuel;
    [SerializeField] private Animator mnemo00Animator;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;
    [SerializeField] private MessageInfo messageInfoOnArm2;

    // messages on ARM2 MessageArea
    private readonly string vtuk = "ВТУК ";
    private readonly string isReturned = " убран с участка подачи комплектующих";
    private readonly string messageSourceIsOperator = "Оператор";
    private readonly string positiveStatus = "+";
    private readonly string negativeStatus = "-";

    //messages on attention block two
    private readonly string needToGetVtuk = "Необходимо получить ВТУК на АРМ ввода №2";

    //messages on attention block one
    private readonly string returnEmptyLodgementMessage = "Необходимо вернуть порожний ложемент-свидетель";

    public void ConfirmChoice()
    {
        if (!outputVTUKNumber.text.Equals(""))
        {
            string currentVtuk = outputVTUKNumber.text;
            ARM2Mnemo2.CurrentVTUK = "";
            ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK = "";
            ARM2Mnemo2TextAboutVTUKNumber.text = "";
            ARM2Mnemo2TextAboutAmountOfFuel.text = "";
            infoAboutVTUKNumberOn02Mnemo.text = "";
            ARM2Mnemo0.ShowVTUKInfo();
            ARM2PanelActions.ShowMnemoPanel(mainMnemoARM2);
            outputVTUKNumber.text = "";
            mnemo00Animator.Play("ReturnVTUK");
            if (mnemo00Animator.GetInteger("VTUKGettingCount") % 2 != 0)
            {
                Mnemo00Animation.StartBlinkingTwo(needToGetVtuk);
            }
            else
            {
                Mnemo00Animation.StopBlinkingTwo();
                Mnemo00Animation.StartBlinkingOne(returnEmptyLodgementMessage);
            }
            messageInfoOnArm2.FillInfo(vtuk + currentVtuk + isReturned, messageSourceIsOperator, positiveStatus);
        }
    }
}
