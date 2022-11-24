using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActions : MonoBehaviour
{
    [SerializeField] private Animation3DControl Animation3DControl;
    public void PlayAnimation (Animation animation)
    {
        Animation3DControl.Flag = true;
        animation.Play();
    }
}
