using UnityEngine;

public class MovingFromBuffer : MonoBehaviour
{
    [SerializeField] private MovingToBuffer movingToBuffer;
    [SerializeField] private Animator coordinateManipulatorAnimator;
    [SerializeField] private Animator mnemo00Animator;

    private Animator mnemo08Animator;

    public void MoveFromBuffer()
    {
        string lastBufferAnimation = movingToBuffer.RequiredBufferAnimation;
        string newRequiredBufferAnimation = GetNewBufferAnimationName(lastBufferAnimation);
        mnemo08Animator.Play(newRequiredBufferAnimation);
        coordinateManipulatorAnimator.Play(newRequiredBufferAnimation);
        mnemo00Animator.Play(newRequiredBufferAnimation + "00");
    }

    private string GetNewBufferAnimationName(string lastBufferAnimation)
    {
        return lastBufferAnimation switch
        {
            "MoveTVSFromWashingToBufer" => "MoveTVSFromBuferToDrying",
            "MoveTVSFromDryingToBufer" => "MoveTVSFromBuferToTightnessControl",
            "MoveTVSFromTightnessControlToBufer" => "MoveTVSFromBuferToImpurityControl",
            "MoveTVSFromImpurityControlToBufer" => "MoveTVSFromBuferToWeightControl",
            "MoveTVSFromWeightControlToBufer" => "MoveTVSFromBuferToGeometryControl",
            "MoveTVSFromGeometryControlToBufer" => "MoveTVSFromBufer",
            _ => ""
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemo08Animator = gameObject.GetComponent<Animator>();
    }
}
