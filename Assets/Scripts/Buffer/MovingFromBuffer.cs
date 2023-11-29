using UnityEngine;

public class MovingFromBuffer : MonoBehaviour
{
    [SerializeField] private MovingToBuffer movingToBuffer;
    [SerializeField] private Animator coordinateManipulatorAnimator;
    [SerializeField] private Animator mnemo00Animator;
    [SerializeField] private FromBufferMenu fromBufferMenu;

    private Animator mnemo08Animator;

    public void MoveFromBuffer()
    {
        if (fromBufferMenu.BufferTvsCounter > 0)
        {
            string lastBufferAnimation = movingToBuffer.RequiredBufferAnimation;
            string newRequiredBufferAnimation = GetNewBufferAnimationName(lastBufferAnimation);
            mnemo08Animator.Play(newRequiredBufferAnimation);
            coordinateManipulatorAnimator.Play(newRequiredBufferAnimation);
            mnemo00Animator.Play(newRequiredBufferAnimation + "00");
            fromBufferMenu.RemoveTvsFromBuffer();
        }
    }

    private string GetNewBufferAnimationName(string lastBufferAnimation)
    {
        return lastBufferAnimation switch
        {
            "MoveTVSFromWashingToBufer" => "MoveTVSFromBufferToDrying",
            "MoveTVSFromDryingToBufer" => "MoveTVSFromBufferToTightnessControl",
            "MoveTVSFromTightnessControlToBufer" => "MoveTVSFromBufferToImpurityControl",
            "MoveTVSFromImpurityControlToBufer" => "MoveTVSFromBufferToWeightControl",
            "MoveTVSFromWeightControlToBufer" => "MoveTVSFromBufferToGeometryControl",
            "MoveTVSFromGeometryControlToBufer" => "MoveTVSFromBuffer",
            _ => ""
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemo08Animator = gameObject.GetComponent<Animator>();
    }
}
