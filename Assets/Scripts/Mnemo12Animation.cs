using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Animation : MonoBehaviour
{
    [SerializeField] private Text weightControlIsDoneText;
    [SerializeField] private Text inputControlIsDoneText;
    [SerializeField] private Text lockControlIsDoneText;
    [SerializeField] private Text suzControlIsDoneText;

    private bool isChecked;

    private readonly string done = "Выполнен";

    public bool IsChecked { get => isChecked; set => isChecked = value; }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = done;
    }

    public void SetWeightControlIsDone()
    {
        IsDone(weightControlIsDoneText);
    }

    public void SetInputControlIsDone()
    {
        IsDone(inputControlIsDoneText);
    }

    public void SetLockControlIsDone()
    {
        IsDone(lockControlIsDoneText);
    }

    public void SetSuzControlIsDone()
    {
        IsDone(suzControlIsDoneText);
    }
}
