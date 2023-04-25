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
    private bool WeightControl = false;
    private bool GeometryControl = false;
    private bool ImpurityControl = false;
    private bool TightnessControl = false;

    private readonly Vector3 tvsWashingTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWashingTarget = new(362.3f, -173.7f, 0.0f);

    private readonly Vector3 tvsDryingTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorDryingTarget = new(362.3f, -173.7f, 0.0f);
    
    private readonly Vector3 tvsWeightComtrolTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorWeightComtrolTarget = new(362.3f, -173.7f, 0.0f);
    
    private readonly Vector3 tvsGeometryControlTarget = new(359.0f, -270.0f, 0.0f);
    private readonly Vector3 manipulatorGeometryControlTarget = new(362.3f, -173.7f, 0.0f);
    private readonly float speed = 0.5f;

    float timeOfTravel = 1000; //time after object reach a target place 
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

        if (IsWashing)
        {
            MoveManipulatorAndTVSToWashing();
        }

        if (IsDrying)
        {
            MoveToCertainPlace(tvsDryingTarget, manipulatorDryingTarget);
        }

        if (WeightControl)
        {
            MoveToCertainPlace(tvsWeightComtrolTarget, manipulatorWeightComtrolTarget);
        }

        if (GeometryControl)
        {
            MoveToCertainPlace(tvsGeometryControlTarget, manipulatorGeometryControlTarget);
        }
    }

    private void MoveManipulatorAndTVSToWashing()
    {
        mnemo08Animator.enabled = false;
        MoveToCertainPlace(tvsWashingTarget, manipulatorWashingTarget);
    }

    private void MoveToCertainPlace(Vector3 tvsTarget, Vector3 manipulatorTarget)
    {
        while (currentTime <= timeOfTravel)
        {
            currentTime += Time.deltaTime;
            normalizedValue = currentTime / timeOfTravel;  

            TVS.rectTransform.anchoredPosition = Vector3.Lerp(TVS.rectTransform.anchoredPosition, tvsTarget, normalizedValue);
            Manipulator.transform.localPosition = Vector3.Lerp(Manipulator.transform.localPosition, manipulatorTarget, normalizedValue);
            if ((currentTime >= timeOfTravel))
            {
                isWashing = false;
                mnemo08Animator.enabled = true;
                mnemo08Animator.Play("08 Mnemo Animation Washing");
            }
        }
    }

    public void MoveToBufferStore()
    {
        Manipulator.transform.Translate((new Vector3(-374f, 123f)));
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(-374f, -269f));
    }

    public void MoveFromBufferStore(GameObject target)
    {
        Manipulator.transform.Translate(target.transform.position);
        TVS.transform.Translate(target.transform.position);
    }

    public void MoveToAssembly()
    {
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(0f, -170f, 0f));
    }

    public void MoveFromAssembly()
    {
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(485f, -270f, 0f));
    }

    private void SetIsWashingTrue()
    {
        IsWashing = true;
    }

    private void SetIsDryingTrue()
    {
        IsDrying = true;
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
