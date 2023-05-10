using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo8Animation : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private Image TVS;
    [SerializeField] private Text currentTVSNumberText;
    [SerializeField] private Animator mnemo08Animator;
    [SerializeField] private Animator coordinateManipulatorAnimator;

    public ARM2Mnemo0 aRM2Mnemo0;

    private bool isWashing = false;
    private bool IsDrying = false;
    private bool TightnessControl = false;
    private bool ImpurityControl = false;
    private bool WeightControl = false;
    private bool GeometryControl = false;
    private bool readyToControl = false;

    private readonly Vector3 tvsWashingTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTarget = new(362.3f, -173.7f, 0.0f);

    private readonly Vector3 tvsDryingTarget = new(310.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTarget = new(311f, -173.7f, 0.0f);

    private readonly Vector3 tvsTightnessControlTarget = new(188.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorTightnessControlTarget = new(189.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsImpurityControlTarget = new(65.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorImpurityControlTarget = new(66.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsWeightControlTarget = new(-102.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWeightControlTarget = new(-101.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsGeometryControlTarget = new(-224.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorGeometryControlTarget = new(-223.0f, -173.7f, 0.0f);

    // Movement speed in units per second.
    public float speed = 1.0f;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float tvsJourneyLength;
    private float manipulatorJourneyLength;

    private RectTransform tvsStartTransform;
    private Transform manipulatorStartTransform;
    public bool IsWashing { get => isWashing; set => isWashing = value; }
    public bool ReadyToControl { get => readyToControl; set => readyToControl = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentTVSNumberText.text = "";
        TVS.transform.position = new Vector3(486f, -270f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        currentTVSNumberText.text = aRM2Mnemo0.FrameNumber.text;

        if (IsWashing && MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget, "08 Mnemo Animation Washing",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            IsWashing = false;
        }

        if (IsDrying && MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget, "08 Mnemo Animation Drying",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            IsDrying = false;
        }

        if (TightnessControl && MoveToCertainPlace(tvsTightnessControlTarget, manipulatorTightnessControlTarget, "08 Mnemo Animation Tightness",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            TightnessControl = false;
        }

        if (ImpurityControl && MoveToCertainPlace(tvsImpurityControlTarget, manipulatorImpurityControlTarget, "08 Mnemo Animation Impurity",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            ImpurityControl = false;
        }

        if (WeightControl && MoveToCertainPlace(tvsWeightControlTarget, manipulatorWeightControlTarget, "08 Mnemo Animation Weight",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            WeightControl = false;
        }

        if (GeometryControl && MoveToCertainPlace(tvsGeometryControlTarget, manipulatorGeometryControlTarget, "08 Mnemo Animation Geometry",
            startTime, tvsStartTransform, manipulatorStartTransform))
        {
            GeometryControl = false;
        }
    }

    private bool MoveToCertainPlace(Vector3 tvsTarget, Vector3 manipulatorTarget, string animName,
        float startTime, RectTransform tvsStartTransform, Transform manipulatorStartTransform)
    {
        mnemo08Animator.enabled = false;

        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        tvsJourneyLength = Vector3.Distance(tvsStartTransform.anchoredPosition, tvsTarget);
        manipulatorJourneyLength = Vector3.Distance(manipulatorStartTransform.localPosition, manipulatorTarget);

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfTVSJourney = distCovered / tvsJourneyLength;
        float fractionOfManipulatorJourney = distCovered / manipulatorJourneyLength;

        // Set our position as a fraction of the distance between the markers.
        TVS.rectTransform.anchoredPosition = Vector3.Lerp(tvsStartTransform.anchoredPosition, tvsTarget, fractionOfTVSJourney);
        Manipulator.transform.localPosition = Vector3.Lerp(manipulatorStartTransform.localPosition, manipulatorTarget, fractionOfManipulatorJourney);

        if (TVS.rectTransform.anchoredPosition.x >= tvsTarget.x & TVS.rectTransform.anchoredPosition.y >= tvsTarget.y)
        {
            mnemo08Animator.enabled = true;
            mnemo08Animator.Play(animName);
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

    private void SetReadyToControlTrue()
    {
        mnemo08Animator.enabled = false;
        ReadyToControl = true;
    }    
    
    public void SetIsWashingTrue()
    {
        IsWashing = true;
        SetStartState(tvsWashingTarget, manipulatorWashingTarget);
    }

    private void SetIsDryingTrue()
    {
        IsDrying = true;
        SetStartState(tvsDryingTarget, manipulatorDryingTarget);

    }
    private void SetTightnessControlTrue()
    {
        TightnessControl = true;
        SetStartState(tvsTightnessControlTarget, manipulatorTightnessControlTarget);
    }

    private void SetImpurityControlTrue()
    {
        ImpurityControl = true;
        SetStartState(tvsImpurityControlTarget, manipulatorImpurityControlTarget);
    }

    private void SetWeightControlTrue()
    {
        WeightControl = true;
        SetStartState(tvsWeightControlTarget, manipulatorWeightControlTarget);
    }

    private void SetGeometryControlTrue()
    {
        GeometryControl = true;
        SetStartState(tvsGeometryControlTarget, manipulatorGeometryControlTarget);
    }

    private void SetStartState(Vector3 tvsTarget, Vector3 manipulatorTarget)
    {
        startTime = Time.time;
        tvsStartTransform = TVS.rectTransform;
        manipulatorStartTransform = Manipulator.transform;

        // Calculate the journey length.
        tvsJourneyLength = Vector3.Distance(tvsStartTransform.position, tvsTarget);
        manipulatorJourneyLength = Vector3.Distance(manipulatorStartTransform.localPosition, manipulatorTarget);
    }

    public void Start3DManipulatorAnimation()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2");
    }
}
