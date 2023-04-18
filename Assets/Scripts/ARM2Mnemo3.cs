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

    public void ConfirmChoice()
    {
        if (!outputVTUKNumber.text.Equals(""))
        {
            ARM2Mnemo2.CurrentVTUK = "";
            ARM2Mnemo2.CurrentTotalAmountOfFuelElementsInVTUK = "";
            ARM2Mnemo2TextAboutVTUKNumber.text = "";
            ARM2Mnemo2TextAboutAmountOfFuel.text = "";
            infoAboutVTUKNumberOn02Mnemo.text = "";
            ARM2Mnemo0.ShowVTUKInfo();
            ARM2PanelActions.ShowMnemoPanel(mainMnemoARM2);
            outputVTUKNumber.text = "";
            mnemo00Animator.Play("ReturnVTUK");
        }
    }
}
