using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingToBuffer : MonoBehaviour
{
    [SerializeField] private AnimationClip mnemo08Washing;
    [SerializeField] private AnimationClip mnemo08Drying;
    [SerializeField] private AnimationClip mnemo08Tightness;
    [SerializeField] private AnimationClip mnemo08Impurity;
    [SerializeField] private AnimationClip mnemo08Weight;
    [SerializeField] private AnimationClip mnemo08Geometry;
    [SerializeField] private Animator coordinateManipulatorAnimator;
    [SerializeField] private Animator mnemo00Animator;
    [SerializeField] private FromBufferMenu fromBufferMenu;
    [SerializeField] private ARM2Mnemo1 arm2Mnemo1;
    [SerializeField] private Mnemo8Animation mnemo8Animation;
    [SerializeField] private Image bufferIndicator;
    [SerializeField] private Image bufferIndicatorOnMnemo00;

    private Animator mnemo08Animator;
    private List<AnimationClip> mnemo08Animation;

    private string requiredBufferAnimation = "";

    public string RequiredBufferAnimation { get => requiredBufferAnimation; set => requiredBufferAnimation = value; }

    public void MoveToBuffer()
    {
        if (fromBufferMenu.BufferTvsCounter < 4)
        {
            string currentAnimationName = mnemo08Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
            AnimationClip currentAnimation = mnemo08Washing;
            foreach (AnimationClip animation in mnemo08Animation)
            {
                if (animation.name.Equals(currentAnimationName))
                {
                    currentAnimation = animation;
                    requiredBufferAnimation = GetBufferAnimationName(currentAnimationName);
                    break;
                }
            }
            StartCoroutine(waiter(currentAnimation, requiredBufferAnimation, currentAnimationName));
        }
    }

    System.Collections.IEnumerator waiter(AnimationClip currentAnimation, string bufferAnimationName, string currentAnimationName)
    {
        //wait untill current animation is finished
        yield return new WaitForSeconds(currentAnimation.length - mnemo08Animator.GetCurrentAnimatorStateInfo(0).normalizedTime * mnemo08Animator.GetCurrentAnimatorStateInfo(0).length - 1);
        SetFlagInMnemo08Animation(currentAnimationName);
        bufferIndicator.color = Color.green;
        bufferIndicatorOnMnemo00.color = Color.green;
        mnemo08Animator.Play(bufferAnimationName);
        coordinateManipulatorAnimator.Play(bufferAnimationName);
        mnemo00Animator.Play(bufferAnimationName + "00");
        fromBufferMenu.AddTvsToBuffer(arm2Mnemo1.CurrentContainerNumber);
    }

    private string GetBufferAnimationName(string currentAnimationName)
    {
        return currentAnimationName switch
        {
            "08 Mnemo Animation Washing" => "MoveTVSFromWashingToBufer",
            "08 Mnemo Animation Drying" => "MoveTVSFromDryingToBufer",
            "08 Mnemo Animation Tightness" => "MoveTVSFromTightnessControlToBufer",
            "08 Mnemo Animation Impurity" => "MoveTVSFromImpurityControlToBufer",
            "08 Mnemo Animation Weight" => "MoveTVSFromWeightControlToBufer",
            "08 Mnemo Animation Geometry" => "MoveTVSFromGeometryControlToBufer",
            _ => ""
        };
    }

    private void SetFlagInMnemo08Animation(string currentAnimationName)
    {
        switch (currentAnimationName)
        {
            case "08 Mnemo Animation Washing": mnemo8Animation.IsDrying = false; break;
            case "08 Mnemo Animation Drying": mnemo8Animation.TightnessControl = false; break;
            case "08 Mnemo Animation Tightness": mnemo8Animation.ImpurityControl = false; break;
            case "08 Mnemo Animation Impurity": mnemo8Animation.WeightControl = false; break;
            case "08 Mnemo Animation Weight": mnemo8Animation.GeometryControl = false; break;
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemo08Animator = gameObject.GetComponent<Animator>();
        mnemo08Animation = new List<AnimationClip> { mnemo08Washing, mnemo08Drying, mnemo08Tightness, mnemo08Impurity, mnemo08Weight, mnemo08Weight };
    }
}
