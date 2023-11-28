using UnityEngine;
using UnityEngine.UI;

public class ARM2Mnemo4 : MonoBehaviour
{
    [SerializeField] private GameObject emptyLodgementOnMnemo00;
    [SerializeField] private Mnemo00Animation Mnemo00Animation;

    [SerializeField] Text emptyLodgementNumber;
    public void Confirm()
    {
        if (!emptyLodgementNumber.text.Equals(""))
        {
            emptyLodgementOnMnemo00.SetActive(false);
            Mnemo00Animation.StopBlinkingOne();
            emptyLodgementNumber.text = "";
        }
    }
}
