using UnityEngine;
using UnityEngine.UI;

public class Mnemo00ForMnemo08 : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private Image TVS;
    [SerializeField] private Mnemo8Animation mnemo8Animation;

    private Animator mnemo00Animator;

    private readonly Vector3 tvsWashingTarget = new(484.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTarget = new(501.0f, -8.0f, 0.0f);

    private readonly Vector3 tvsDryingTarget = new(432.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTarget = new(448.0f, -8.0f, 0.0f);

    private readonly Vector3 tvsTightnessControlTarget = new(335.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorTightnessControlTarget = new(350.0f, -8f, 0.0f);

    private readonly Vector3 tvsImpurityControlTarget = new(236.0f, -84.0f, 0.0f);
    private readonly Vector3 manipulatorImpurityControlTarget = new(250f, -8f, 0.0f);

    //private readonly Vector3 tvsWeightControlTarget = new(432.0f, -84.0f, 0.0f);
    //private readonly Vector3 manipulatorWeightControlTarget = new(448f, -8f, 0.0f);

    //private readonly Vector3 tvsGeometryControlTarget = new(432.0f, -84.0f, 0.0f);
    //private readonly Vector3 manipulatorGeometryControlTarget = new(448f, -8f, 0.0f);

    // Movement speed in units per second.
    private readonly float speed = 1.0f;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float tvsJourneyLength;
    private float manipulatorJourneyLength;

    private RectTransform tvsStartTransform;
    private Transform manipulatorStartTransform;

    // Start is called before the first frame update
    void Start()
    {
        mnemo00Animator = gameObject.GetComponent<Animator>();
        TVS.transform.position = new Vector3(769f, -84f, 0);
    }

    void Update()
    {
        if (mnemo8Animation.IsWashing)
        {
            MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget, "Mnemo00 Washing", startTime, tvsStartTransform, manipulatorStartTransform);
        }

        if (mnemo8Animation.IsDrying)
        {
            MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget, "Mnemo00 Drying", startTime, tvsStartTransform, manipulatorStartTransform);
        }

        if (mnemo8Animation.TightnessControl)
        {
            MoveToTightnessControl();
        }

        //if (mnemo8Animation.ImpurityControl)
        //{

        //}

        //if (mnemo8Animation.WeightControl)
        //{
        //}

        //if (mnemo8Animation.GeometryControl)
        //{

        //}
    }

    //public void MoveToWashing()
    //{
    //    MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget, "Mnemo00 Washing", startTime, tvsStartTransform, manipulatorStartTransform);
    //}

    //public void MoveToDrying()
    //{
    //    MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget, "Mnemo00 Drying", startTime, tvsStartTransform, manipulatorStartTransform);
    //}

    public void MoveToTightnessControl()
    {
        MoveToCertainPlace(tvsTightnessControlTarget, manipulatorTightnessControlTarget, "Mnemo00 TightnessControl", startTime, tvsStartTransform, manipulatorStartTransform);
    }

    //public void MoveToImpurityControl()
    //{
    //    SetStartState();
    //    MoveToCertainPlace(tvsImpurityControlTarget, manipulatorImpurityControlTarget, "Mnemo00 ImpurityControl", startTime, tvsStartTransform, manipulatorStartTransform);
    //}

    //public void MoveToWeightControl()
    //{
    //    SetStartState();
    //    MoveToCertainPlace(tvsWeightControlTarget, manipulatorWeightControlTarget, "08 Mnemo Animation Weight", startTime, tvsStartTransform, manipulatorStartTransform);
    //}

    //public void MoveToGeometryControl()
    //{
    //    SetStartState();
    //    MoveToCertainPlace(tvsGeometryControlTarget, manipulatorGeometryControlTarget, "08 Mnemo Animation Geometry", startTime, tvsStartTransform, manipulatorStartTransform);
    //}

    private bool MoveToCertainPlace(Vector3 tvsTarget, Vector3 manipulatorTarget, string animName,
        float startTime, RectTransform tvsStartTransform, Transform manipulatorStartTransform)
    {
        mnemo00Animator.enabled = false;

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
            mnemo00Animator.enabled = true;
            mnemo00Animator.Play(animName);
            return true;
        }
        return false;
    }

    public void SetStartState()
    {
        startTime = Time.time;
        tvsStartTransform = TVS.rectTransform;
        manipulatorStartTransform = Manipulator.transform;
    }
}
