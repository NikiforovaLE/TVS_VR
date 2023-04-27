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
    public ARM2Mnemo0 aRM2Mnemo0;

    private bool isWashing = false;
    private bool IsDrying = false;
    private bool TightnessControl = false;
    private bool ImpurityControl = false;
    private bool WeightControl = false;
    private bool GeometryControl = false;

    private readonly Vector3 tvsWashingTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTarget = new(362.3f, -173.7f, 0.0f);

    private readonly Vector3 tvsDryingTarget = new(310.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTarget = new(362.3f, -173.7f, 0.0f);

    private readonly Vector3 tvsTightnessControlTarget = new(188.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorTightnessControlTarget = new(189.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsImpurityControlTarget = new(65.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorImpurityControlTarget = new(66.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsWeightControlTarget = new(-102.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWeightControlTarget = new(-101.0f, -173.7f, 0.0f);

    private readonly Vector3 tvsGeometryControlTarget = new(-224.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorGeometryControlTarget = new(-223.0f, -173.7f, 0.0f);

    private readonly float speed = 0.5f;
    readonly float timeOfTravel = 1f; //time after object reach a target place 
    float currentTime = 0; // actual floting time 
    float normalizedValue;

    public bool IsWashing { get => isWashing; set => isWashing = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentTVSNumberText.text = "";
        TVS.transform.position = new Vector3(486f, -270f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTVSNumberText.text = aRM2Mnemo0.FrameNumber.text;

        if (IsWashing && MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget, "08 Mnemo Animation Washing"))
        {
            IsWashing = false;
        }

        if (IsDrying && MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget, "08 Mnemo Animation Drying"))
        {
            IsDrying = false;
        }

        if (TightnessControl && MoveToCertainPlace(tvsTightnessControlTarget, manipulatorTightnessControlTarget, "08 Mnemo Animation Tightness"))
        {
            TightnessControl = false;
        }

        if (ImpurityControl && MoveToCertainPlace(tvsImpurityControlTarget, manipulatorImpurityControlTarget, "08 Mnemo Animation Impurity"))
        {
            ImpurityControl = false;
        }

        if (WeightControl && MoveToCertainPlace(tvsWeightControlTarget, manipulatorWeightControlTarget, "08 Mnemo Animation Weight"))
        {
            WeightControl = false;
        }

        if (GeometryControl && MoveToCertainPlace(tvsGeometryControlTarget, manipulatorGeometryControlTarget, "08 Mnemo Animation Geometry"))
        {
            GeometryControl = false;
        }
    }

    private bool MoveToCertainPlace(Vector3 tvsTarget, Vector3 manipulatorTarget, string animName)
    {
        mnemo08Animator.enabled = false;
        while (currentTime <= timeOfTravel)
        {
            currentTime += Time.deltaTime;
            normalizedValue = currentTime / timeOfTravel;

            TVS.rectTransform.anchoredPosition = Vector3.Lerp(TVS.rectTransform.anchoredPosition, tvsTarget, speed);
            Manipulator.transform.localPosition = Vector3.Lerp(Manipulator.transform.localPosition, manipulatorTarget, speed);
        }
        if (currentTime >= timeOfTravel)
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

    private void SetIsWashingTrue()
    {
        IsWashing = true;
    }

    private void SetIsDryingTrue()
    {
        IsDrying = true;
    }
    private void SetTightnessControlTrue()
    {
        TightnessControl = true;
    }

    private void SetImpurityControlTrue()
    {
        ImpurityControl = true;
    }

    private void SetWeightControlTrue()
    {
        WeightControl = true;
    }

    private void SetGeometryControlTrue()
    {
        GeometryControl = true;
    }
}
