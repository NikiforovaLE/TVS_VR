using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingToBuffer : MonoBehaviour
{
    [SerializeField] GameObject mnemo08;
    [SerializeField] AnimationClip mnemo08Washing;
    [SerializeField] AnimationClip mnemo08Drying;
    [SerializeField] AnimationClip mnemo08Tightness;
    [SerializeField] AnimationClip mnemo08Impurity;
    [SerializeField] AnimationClip mnemo08Weight;
    [SerializeField] AnimationClip mnemo08Geometry;

    private Animator mnemo08Animator;
    private List<AnimationClip> mnemo08Animation;
    private int count = 0;
    public void MoveToBuffer()
    {
        string currentAnimationName = mnemo08Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
        AnimationClip currentAnimation = mnemo08Washing;
        string bufferAnimationName = "";
        foreach (AnimationClip animation in mnemo08Animation)
        {
            if (animation.name.Equals(currentAnimationName))
            {
                currentAnimation = animation;
                bufferAnimationName = GetBufferAnimationName(currentAnimationName);
                break;
            }
        }
        while (mnemo08Animator.GetCurrentAnimatorStateInfo(0).IsName(currentAnimationName))
        {
            count = 0;
        }
        mnemo08Animator.Play(bufferAnimationName);
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
        mnemo08Animator = mnemo08.GetComponent<Animator>();
        mnemo08Animation = new List<AnimationClip> { mnemo08Washing, mnemo08Drying, mnemo08Tightness, mnemo08Impurity, mnemo08Weight, mnemo08Weight };
    }
}
