using UnityEngine;

public class MovingFromBuffer : MonoBehaviour
{
    [SerializeField] private MovingToBuffer movingToBuffer;
    [SerializeField] private Animator coordinateManipulatorAnimator;
    [SerializeField] private Animator mnemo00Animator;
    [SerializeField] private FromBufferMenu fromBufferMenu;
    [SerializeField] private CoordinateManipulatorAnimator coordinateManipulatorAnimatorScript;

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


    public void StartManipulatorMovingOnWashing()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.11712067f);
    }

    public void StartManipulatorMovingOnDrying()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.22502961f);
    }

    public void StartManipulatorMoving2OnTightnessControl()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.31991051f);
    }

    public void StartManipulatorMoving2OnImpurityControl()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.41465982f);
    }

    public void StartManipulatorMoving2OnWeightControl()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.50954073f);
    }

    public void StartManipulatorMoving2OnGeometryControl()
    {
        coordinateManipulatorAnimator.Play("ManipulatorMoving2", 0, 0.81668641f);
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemo08Animator = gameObject.GetComponent<Animator>();
    }
}
