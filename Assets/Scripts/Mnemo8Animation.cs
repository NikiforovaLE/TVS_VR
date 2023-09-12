using UnityEngine;
using UnityEngine.UI;

public class Mnemo8Animation : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private Image TVS;
    [SerializeField] private Text currentTVSNumberText;

    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private Animator coordinateManipulatorAnimator;

    [SerializeField] private GameObject mnemo09;
    [SerializeField] private GameObject mnemo11;
    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GeneralPanelAcions AdditionalGeneralPanelAcions;

    public ARM2Mnemo0 aRM2Mnemo0;

    private bool isWashing = false;
    private bool isDrying = false;
    private bool tightnessControl = false;
    private bool impurityControl = false;
    private bool weightControl = false;
    private bool geometryControl = false;
    private bool readyToControl = false;


    private readonly Vector3 tvsWashingTarget = new(177.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTarget = new(178.0f, 11.3f, 0.0f);

    private readonly Vector3 tvsDryingTarget = new(129.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTarget = new(129.5f, 11.3f, 0.0f);

    private readonly Vector3 tvsTightnessControlTarget = new(7.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorTightnessControlTarget = new(7.5f, 11.3f, 0.0f);

    private readonly Vector3 tvsImpurityControlTarget = new(-118.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorImpurityControlTarget = new(-117.5f, 11.3f, 0.0f);

    private readonly Vector3 tvsWeightControlTarget = new(-284.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorWeightControlTarget = new(-283.5f, 5f, 0.0f);

    private readonly Vector3 tvsGeometryControlTarget = new(-405.0f, -91.0f, 0.0f);
    private readonly Vector3 manipulatorGeometryControlTarget = new(-405.0f, 11.3f, 0.0f);

    //for mnemo00
    [SerializeField] private GameObject ManipulatorFromMnemo00;
    [SerializeField] private Image TVSFromMnemo00;

    [SerializeField] private Animator mnemo00Animator;

    private readonly Vector3 tvsWashingTargetForMnemo00 = new(484.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTargetForMnemo00 = new(501f, -8f, 0.0f);

    private readonly Vector3 tvsDryingTargetForMnemo00 = new(432.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTargetForMnemo00 = new(448f, -8f, 0.0f);

    private readonly Vector3 tvsTightnessControlTargetForMnemo00 = new(335.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorTightnessControlTargetForMnemo00 = new(350.0f, -8f, 0.0f);

    private readonly Vector3 tvsImpurityControlTargetForMnemo00 = new(236.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorImpurityControlTargetForMnemo00 = new(250f, -8f, 0.0f);

    private readonly Vector3 tvsWeightControlTargetForMnemo00 = new(108.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorWeightControlTargetForMnemo00 = new(120f, -8f, 0.0f);

    private readonly Vector3 tvsGeometryControlTargetForMnemo00 = new(10.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorGeometryControlTargetForMnemo00 = new(20f, -8f, 0.0f);

    // Total distance between the markers.
    private float tvsJourneyLengthForMnemo00;
    private float manipulatorJourneyLengthForMnemo00;

    private RectTransform tvsStartTransformForMnemo00;
    private Transform manipulatorStartTransformForMnemo00;

    // Movement speed in units per second.
    private readonly float speed = 0.5f;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float tvsJourneyLength;
    private float manipulatorJourneyLength;

    private RectTransform tvsStartTransform;
    private Transform manipulatorStartTransform;

    public bool IsWashing { get => isWashing; set => isWashing = value; }
    public bool ReadyToControl { get => readyToControl; set => readyToControl = value; }
    public bool IsDrying { get => isDrying; set => isDrying = value; }
    public bool TightnessControl { get => tightnessControl; set => tightnessControl = value; }
    public bool ImpurityControl { get => impurityControl; set => impurityControl = value; }
    public bool WeightControl { get => weightControl; set => weightControl = value; }
    public bool GeometryControl { get => geometryControl; set => geometryControl = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentTVSNumberText.text = "";
        TVS.transform.position = new Vector3(303.0f, -271.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        currentTVSNumberText.text = aRM2Mnemo0.FrameNumber.text;

        if (IsWashing && MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget, "08 Mnemo Animation Washing",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsWashingTargetForMnemo00, manipulatorWashingTargetForMnemo00, "Mnemo00 Washing",
            tvsStartTransformForMnemo00, manipulatorStartTransformForMnemo00,
            "readyToWashing"))
        {
            IsWashing = false;
        }

        if (IsDrying && MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget, "08 Mnemo Animation Drying",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsDryingTargetForMnemo00, manipulatorDryingTargetForMnemo00, "Mnemo00 Drying",
            tvsStartTransformForMnemo00, manipulatorStartTransformForMnemo00,
            "readyToDrying"))
        {
            IsDrying = false;
        }

        if (TightnessControl && MoveToCertainPlace(tvsTightnessControlTarget, manipulatorTightnessControlTarget, "08 Mnemo Animation Tightness",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsTightnessControlTargetForMnemo00, manipulatorTightnessControlTargetForMnemo00, "Mnemo00 TightnessControl",
            tvsStartTransformForMnemo00, manipulatorStartTransformForMnemo00,
            "readyToTightnessControl"))
        {
            TightnessControl = false;
        }

        if (ImpurityControl && MoveToCertainPlace(tvsImpurityControlTarget, manipulatorImpurityControlTarget, "08 Mnemo Animation Impurity",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsImpurityControlTargetForMnemo00, manipulatorImpurityControlTargetForMnemo00, "Mnemo00 ImpurityControl",
            tvsStartTransformForMnemo00, manipulatorStartTransformForMnemo00,
            "readyToImpurityControl"))
        {
            ImpurityControl = false;
        }

        if (WeightControl && MoveToCertainPlace(tvsWeightControlTarget, manipulatorWeightControlTarget, "08 Mnemo Animation Weight",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsWeightControlTargetForMnemo00, manipulatorWeightControlTargetForMnemo00, "Mnemo00 WeightControl",
            tvsStartTransformForMnemo00, manipulatorStartTransformForMnemo00,
            "readyToWeightControl"))
        {
            WeightControl = false;
        }

        if (GeometryControl && MoveToCertainPlace(tvsGeometryControlTarget, manipulatorGeometryControlTarget, "08 Mnemo Animation Geometry",
            startTime, tvsStartTransform, manipulatorStartTransform,
            tvsGeometryControlTargetForMnemo00, manipulatorGeometryControlTargetForMnemo00, "Mnemo00 GeometryControl", tvsStartTransformForMnemo00,
            manipulatorStartTransformForMnemo00,
            "readyToGeometryControl"))
        {
            GeometryControl = false;
        }
    }

    private bool MoveToCertainPlace(Vector3 tvsTarget, Vector3 manipulatorTarget, string animName,
        float startTime, RectTransform tvsStartTransform, Transform manipulatorStartTransform,
        Vector3 tvsTargetForMnemo00, Vector3 manipulatorTargetForMnemo00, string animNameForMnemo00,
        RectTransform tvsStartTransformForMnemo00, Transform manipulatorStartTransformForMnemo00,
        string boolName
        )
    {
        mnemo08Animator.enabled = false;
        mnemo00Animator.enabled = false;

        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        tvsJourneyLength = Vector3.Distance(tvsStartTransform.anchoredPosition, tvsTarget);
        manipulatorJourneyLength = Vector3.Distance(manipulatorStartTransform.localPosition, manipulatorTarget);

        tvsJourneyLengthForMnemo00 = Vector3.Distance(tvsStartTransformForMnemo00.anchoredPosition, tvsTargetForMnemo00);
        manipulatorJourneyLengthForMnemo00 = Vector3.Distance(manipulatorStartTransformForMnemo00.localPosition, manipulatorTargetForMnemo00);

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfTVSJourney = distCovered / tvsJourneyLength;
        float fractionOfManipulatorJourney = distCovered / manipulatorJourneyLength;

        // Fraction of journey completed equals current distance divided by total distance for mnemo00.
        float fractionOfTVSJourneyForMnemo00 = distCovered / tvsJourneyLengthForMnemo00;
        float fractionOfManipulatorJourneyForMnemo00 = distCovered / manipulatorJourneyLengthForMnemo00;

        // Set our position as a fraction of the distance between the markers.
        TVS.rectTransform.anchoredPosition = Vector3.Lerp(tvsStartTransform.anchoredPosition, tvsTarget, fractionOfTVSJourney);
        Manipulator.transform.localPosition = Vector3.Lerp(manipulatorStartTransform.localPosition, manipulatorTarget, fractionOfManipulatorJourney);

        // Set our position as a fraction of the distance between the markers for mnemo00.
        TVSFromMnemo00.rectTransform.anchoredPosition = Vector3.Lerp(tvsStartTransformForMnemo00.anchoredPosition, tvsTargetForMnemo00, fractionOfTVSJourneyForMnemo00);
        ManipulatorFromMnemo00.transform.localPosition = Vector3.Lerp(manipulatorStartTransformForMnemo00.localPosition, manipulatorTargetForMnemo00, fractionOfManipulatorJourneyForMnemo00);

        if (TVS.rectTransform.anchoredPosition.x >= tvsTarget.x & TVS.rectTransform.anchoredPosition.y >= tvsTarget.y
            //&& TVSFromMnemo00.rectTransform.anchoredPosition.x >= tvsTargetForMnemo00.x & TVSFromMnemo00.rectTransform.anchoredPosition.y >= tvsTargetForMnemo00.y
            && coordinateManipulatorAnimator.GetBool(boolName)
            && coordinateManipulatorAnimator.speed == 0)
        {
            coordinateManipulatorAnimator.speed = 1;
            mnemo08Animator.enabled = true;
            mnemo00Animator.enabled = true;
            mnemo08Animator.Play(animName);
            mnemo00Animator.Play(animNameForMnemo00);
            return true;
        }
        return false;
    }

    public void MoveToBufferStore()
    {
        Manipulator.transform.Translate((new Vector3(-374f, 123f)));
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(-374f, -269f));
    }

    public void MoveToAssembly()
    {
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(0f, -170f, 0f));
    }

    public void SetReadyToControlTrue()
    {
        mnemo08Animator.enabled = false;
        ReadyToControl = true;
    }

    public void SetIsWashingTrue()
    {
        IsWashing = true;
        SetStartState();
        Start3DManipulatorAnimation();
    }

    private void SetIsDryingTrue()
    {
        IsDrying = true;
        SetStartState();
    }
    private void SetTightnessControlTrue()
    {
        TightnessControl = true;
        SetStartState();
    }

    private void SetImpurityControlTrue()
    {
        ImpurityControl = true;
        SetStartState();
    }

    private void SetWeightControlTrue()
    {
        WeightControl = true;
        SetStartState();
    }

    private void SetGeometryControlTrue()
    {
        GeometryControl = true;
        SetStartState();
    }

    private void SetStartState()
    {
        startTime = Time.time;
        tvsStartTransform = TVS.rectTransform;
        manipulatorStartTransform = Manipulator.transform;

        //for mnemo00
        tvsStartTransformForMnemo00 = TVSFromMnemo00.rectTransform;
        manipulatorStartTransformForMnemo00 = ManipulatorFromMnemo00.transform;
    }

    public void Start09MnemoAnimationWashing()
    {
        GeneralPanelAcions.SetPanelActive(mnemo09);
        mnemo09.GetComponent<Animator>().Play("09 Mnemo Animation");
    }

    public void Start09MnemoAnimationDrying()
    {
        GeneralPanelAcions.SetPanelActive(mnemo09);
        mnemo09.GetComponent<Animator>().Play("09 Mnemo Animation Drying");
    }

    public void Start11MnemoAnimation()
    {
        GeneralPanelAcions.SetPanelActive(mnemo11);
        mnemo11.GetComponent<Animator>().Play("11 Mnemo Animation");

    }
    public void ContinueCoordinateManipulatorAnimation()
    {
        coordinateManipulatorAnimator.speed = 1;
        mnemo00Animator.speed = 1;
    }

    public void Start3DManipulatorAnimation()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2");
    }

    public void StopCurrentAnimation()
    {
        mnemo08Animator.speed = 0;
        mnemo00Animator.speed = 0;
        coordinateManipulatorAnimator.speed = 0;
    }
}
