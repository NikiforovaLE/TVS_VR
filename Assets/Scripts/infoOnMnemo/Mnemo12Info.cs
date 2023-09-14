using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Info : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo0 ARM2Mnemo0;

    [SerializeField] private Text currentTvs;
    [SerializeField] private Text tvsType;
    [SerializeField] private Text tvsWeight;
    [SerializeField] private Text tvsWeightLoss;
    [SerializeField] private Text suzWeightLoss;
    [SerializeField] private Text weightControResult;
    [SerializeField] private Text inputControlResult;
    [SerializeField] private Text lockControlResult;
    [SerializeField] private Text suzControlResult;
    [SerializeField] private Text capture;
    [SerializeField] private Text tvsRotationAngle;
    [SerializeField] private Text step;

    [SerializeField] private Image isPerformingBackgrond;

    private int stepCount = 0;

    private bool isChecked = false;
    private readonly string tvsWeightIs0 = "0";
    private readonly string tvsWeightIs230 = "230";
    private readonly string tvsWeightLossIs0 = "0";
    private readonly string tvsWeightLossIs60 = "60";
    private readonly string suzWeightLossIs0 = "0";
    private readonly string suzWeightLossIs53 = "53";
    private readonly string controlIsNotDone = "Не выполнен";
    private readonly string controlIsDone = "Выполнен";
    private readonly string captureIsOpened = "Открыт";
    private readonly string captureIsClosed = "Закрыт";
    private readonly string tvsRotationAngleIs0 = "0";
    private readonly string tvsRotationAngleIs120 = "120";
    private readonly string tvsRotationAngleIs240 = "240";
    private readonly string tvsRotationAngleIs360 = "360";

    private readonly Color whenIsNotPerforming = new(255f, 255f, 255f, 255f);

    public bool IsChecked { get => isChecked; set => isChecked = value; }

    public void SetNextStep()
    {
        if (stepCount == 3)
        {
            stepCount = 0;
        }
        step.text = (++stepCount).ToString();
    }

    public void SetTvsWeightIs0()
    {
        tvsWeight.text = tvsWeightIs0;
    }

    public void SetTvsWeightIs230()
    {
        tvsWeight.text = tvsWeightIs230;
    }

    public void SetTvsWeightLossIs0()
    {
        tvsWeightLoss.text = tvsWeightLossIs0;
    }

    public void SetTvsWeightLossIs60()
    {
        tvsWeightLoss.text = tvsWeightLossIs60;
    }

    public void SetSuzWeightLossIs0()
    {
        suzWeightLoss.text = suzWeightLossIs0;
    }

    public void SetWeightControlIsDone()
    {
        SetControlIsDone(weightControResult);
    }

    public void SetInputControlIsDone()
    {
        SetControlIsDone(inputControlResult);
    }

    public void SetLockControlIsDone()
    {
        SetControlIsDone(lockControlResult);
    }

    public void SetSuzControlIsDone()
    {
        SetControlIsDone(suzControlResult);
        suzWeightLoss.text = suzWeightLossIs53;
        IsChecked = true;
        isPerformingBackgrond.color = whenIsNotPerforming;
    }

    public void SetControlIsDone(Text controlResult)
    {
        controlResult.text = controlIsDone;
    }

    public void SetCaptureIsOpened()
    {
        capture.text = captureIsOpened;
    }

    public void SetCaptureIsClosed()
    {
        capture.text = captureIsClosed;
    }

    public void SetTvsRotationAngleIs0()
    {
        tvsRotationAngle.text = tvsRotationAngleIs0;
    }

    public void SetTvsRotationAngleIs120()
    {
        tvsRotationAngle.text = tvsRotationAngleIs120;
    }

    public void SetTvsRotationAngleIs240()
    {
        tvsRotationAngle.text = tvsRotationAngleIs240;
    }

    public void SetTvsRotationAngleIs36()
    {
        tvsRotationAngle.text = tvsRotationAngleIs360;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetTvsWeightIs0();
        SetTvsWeightLossIs0();
        SetSuzWeightLossIs0();
        weightControResult.text = controlIsNotDone;
        inputControlResult.text = controlIsNotDone;
        lockControlResult.text = controlIsNotDone;
        suzControlResult.text = controlIsNotDone;
    }

    // Update is called once per frame
    void Update()
    {
        currentTvs.text = ARM2Mnemo0.FrameNumber.text;
        tvsType.text = ARM2Mnemo0.Type.text;
    }
}
