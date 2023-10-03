using UnityEngine;

public class Mnemo16Animation : MonoBehaviour
{
    [SerializeField] private GameObject mnemo14;
    [SerializeField] private GameObject additionalMnemo15;
    [SerializeField] private GeneralPanelAcions additionalGeneralPanelAcions;
    [SerializeField] private Animator manipulatorCranAnimator;
    public ARM2Mnemo0 ARM2Mnemo0;

    private Animator mnemo14Animator;
    private Animator mnemo15Animator;

    public void Start3DAnimation()
    {
        manipulatorCranAnimator.Play("PenalManipulatorMoving");
    }

    public void StartAnimationOn14MnemoAnd15Mnemo()
    {
        additionalGeneralPanelAcions.SetPanelActive(additionalMnemo15);
        mnemo15Animator.Play("15 Mnemo Animation");
        mnemo14Animator.Play("14 Mnemo Animation");
    }

    // Start is called before the first frame update
    void Start()
    {
        mnemo14Animator = mnemo14.GetComponent<Animator>();
        mnemo15Animator = additionalMnemo15.GetComponent<Animator>();
    }
}