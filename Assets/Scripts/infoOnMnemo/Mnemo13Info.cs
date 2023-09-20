using UnityEngine;
using UnityEngine.UI;

public class Mnemo13Info : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo0 aRM2Mnemo0;

    //info1
    [SerializeField] private Text tvsNumber;
    [SerializeField] private Text tvsLength;
    [SerializeField] private Text tvsLengthControlResult;
    [SerializeField] private Text turnkeySize;
    [SerializeField] private Text turnkeySizeControlResult;
    [SerializeField] private Text appearanceControlResult;

    //info3
    [SerializeField] private Text tvsRotationAngle;
    [SerializeField] private Text turnkeySizeMeasurementLevel;
    [SerializeField] private Text tvsVerticalCoordinate;

    private readonly string zeroValue = "0";
    private readonly string tvsLengthIs = "";
    private readonly string sizeIs = "";
    private readonly string tvsRotationAngleIs = "";
    private readonly string turnkeySizeMeasurementLevelIs = "";
    private readonly string tvsVerticalCoordinateIs7450 = "7450";

    private readonly string controlIsNotDone = "Не выполнен";
    private readonly string controlIsDone = "Выполнен";

    public void GetAndFillTvsNumber()
    {
        tvsNumber.text = aRM2Mnemo0.FrameNumber.text;
    }

    public void SetTvsLengthIs0()
    {
        tvsLength.text = zeroValue;
    }

    public void SetTvsLengthIs()
    {
        tvsLength.text = tvsLengthIs;
    }

    public void SetTvsLengthControlIsDone()
    {
        IsDone(tvsLengthControlResult);
    }

    public void SetTurnkeySizeIs0()
    {
        turnkeySize.text = zeroValue;
    }

    public void SetTurnkeySizeIs()
    {
        turnkeySize.text = sizeIs;
    }

    public void SetTurnkeySizeControlIsDone()
    {
        IsDone(turnkeySizeControlResult);
    }

    public void SetAppearanceControlIsDone()
    {
        IsDone(appearanceControlResult);
    }

    private void IsDone(Text isDoneText)
    {
        isDoneText.text = controlIsDone;
    }
    
    private void SetTvsRotationAngleIs0()
    {
        tvsRotationAngle.text = zeroValue;
    }
    
    private void SetTvsRotationAngleIs()
    {
        tvsRotationAngle.text = tvsRotationAngleIs;
    }
    
    private void SetTurnkeySizeMeasurementLevelIs()
    {
        turnkeySizeMeasurementLevel.text = turnkeySizeMeasurementLevelIs;
    }
    
    private void SetTvsVerticalCoordinateIs0()
    {
        tvsVerticalCoordinate.text = zeroValue;
    }
    
    private void SetTvsVerticalCoordinateIs7450()
    {
        tvsVerticalCoordinate.text = tvsVerticalCoordinateIs7450;
    }

    // Start is called before the first frame update
    void Start()
    {
        tvsNumber.text = "";
        SetTvsLengthIs0();
        tvsLengthControlResult.text = controlIsNotDone;
        SetTurnkeySizeIs0();
        turnkeySizeControlResult.text = controlIsNotDone;
        appearanceControlResult.text = controlIsNotDone;
        SetTvsRotationAngleIs0();
        turnkeySizeMeasurementLevel.text = "";
        SetTvsVerticalCoordinateIs0();
    }
}
