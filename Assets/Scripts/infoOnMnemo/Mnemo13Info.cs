using UnityEngine;
using UnityEngine.UI;

public class Mnemo13Info : MonoBehaviour
{
    [SerializeField] private MessageInfo messageInfoOnMnemo13;

    [SerializeField] private Text tvsLength;
    [SerializeField] private Text size;

    [SerializeField] private Text lengthControlIsDoneText;
    [SerializeField] private Text sizeControlIsDoneText;
    [SerializeField] private Text viewControlIsDoneText;

    private readonly string tvsLengthIs0 = "0";
    private readonly string tvsLengthIs = "";
    private readonly string sizeIs0 = "0";
    private readonly string sizeIs = "";

    private readonly string controlIsNotDone = "Не выполнен";
    private readonly string controlIsDone = "Выполнен";

    public void SetTvsLengthIs0()
    {
        tvsLength.text = tvsLengthIs0;
    }

    public void SetTvsLengthIs()
    {
        tvsLength.text = tvsLengthIs;
    }

    public void SetSizeIs0()
    {
        size.text = sizeIs0;
    }

    public void SetSizeIs()
    {
        size.text = sizeIs;
    }

    public void SetLengthControlIsDone()
    {
        IsDone(lengthControlIsDoneText);
    }

    public void SetSizeControlIsDone()
    {
        IsDone(sizeControlIsDoneText);
    }

    public void SetViewControlIsDoneText()
    {
        IsDone(viewControlIsDoneText);
    }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = controlIsDone;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetTvsLengthIs0();
        SetSizeIs0();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
