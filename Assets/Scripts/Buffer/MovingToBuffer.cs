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
    [SerializeField] private Image bufferIndicator;

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
            StartCoroutine(waiter(currentAnimation, requiredBufferAnimation));
        }
    }

    System.Collections.IEnumerator waiter(AnimationClip currentAnimation, string bufferAnimationName)
    {
        //wait untill current animation is finished
        yield return new WaitForSeconds(currentAnimation.length - mnemo08Animator.GetCurrentAnimatorStateInfo(0).normalizedTime * mnemo08Animator.GetCurrentAnimatorStateInfo(0).length - 1);
        bufferIndicator.color = Color.green;
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

    // Start is called before the first frame update
    void Start()
    {
        mnemo08Animator = gameObject.GetComponent<Animator>();
        mnemo08Animation = new List<AnimationClip> { mnemo08Washing, mnemo08Drying, mnemo08Tightness, mnemo08Impurity, mnemo08Weight, mnemo08Weight };
    }
}
