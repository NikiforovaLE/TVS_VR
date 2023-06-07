using UnityEngine;
using UnityEngine.UI;

public class Mnemo13Animation : MonoBehaviour
{
    [SerializeField] private Text lengthControlIsDoneText;
    [SerializeField] private Text sizeControlIsDoneText;
    [SerializeField] private Text viewControlIsDoneText;

    [SerializeField] private Mnemo12Animation mnemo12Animation;

    [SerializeField] private Animator mnemo14Animator;
    [SerializeField] private Text attentionMessage;
    private bool isChecked;

    private readonly string done = "Выполнен";
    private readonly string messageWhenNotChecked = "Проведите проверку";

    public void isSuitable()
    {
        if (isChecked)
        {
            attentionMessage.text = "";
            mnemo14Animator.Play("14 Mnemo Animation");
        } else
        {
            attentionMessage.text = messageWhenNotChecked;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isChecked = false;
        attentionMessage.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        isChecked = mnemo12Animation.IsChecked;
    }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = done;
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
}
