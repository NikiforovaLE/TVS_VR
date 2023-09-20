using UnityEngine;
using UnityEngine.UI;

public class Mnemo14Info : MonoBehaviour
{
    [SerializeField] private ARM2Mnemo0 aRM2Mnemo0;

    [SerializeField] private Text tvsNumber;
    [SerializeField] private Text boxNumber;
    [SerializeField] private Text gammaCharacteristicMeasurementResult;
    [SerializeField] private Text neutronCharacteristicMeasurementResult;

    private int counter = 1;
    private readonly string box = "œ≈Õ¿À";
    private readonly string emptyLine = "";
    private readonly string measurementResultIs0point2 = "0.2";

    public void GetAndFillTvsAndBoxNumbers()
    {
        tvsNumber.text = aRM2Mnemo0.FrameNumber.text;
        boxNumber.text = box + counter++;
    }
    
    public void Set0point2ToGammaCharacteristicMeasurementResult()
    {
        gammaCharacteristicMeasurementResult.text = measurementResultIs0point2;
    }
    
    public void Set0popint2ToNeutronCharacteristicMeasurementResult()
    {
        neutronCharacteristicMeasurementResult.text = measurementResultIs0point2;
    }

    // Start is called before the first frame update
    void Start()
    {
        tvsNumber.text = emptyLine;
        boxNumber.text = emptyLine;
        gammaCharacteristicMeasurementResult.text = emptyLine;
        neutronCharacteristicMeasurementResult.text = emptyLine;
    }
}
