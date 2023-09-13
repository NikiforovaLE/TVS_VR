using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Animation : MonoBehaviour
{
    [SerializeField] private Image isPerformingBackgrond;

    [SerializeField] private Animator mnemo08Animator;

    [SerializeField] private GeneralPanelAcions GeneralPanelAcions;
    [SerializeField] private GameObject mnemo13;

    private Animator currentAnimator;

    private readonly Color whenIsPerforming = new(0f, 255f, 0f, 255f);

    // Start is called before the first frame update
    void Start()
    {
        currentAnimator = gameObject.GetComponent<Animator>();
    }

    public void StartControl()
    {
        currentAnimator.Play("12 Mnemo Animation");
        mnemo08Animator.speed = 1;
        isPerformingBackgrond.color = whenIsPerforming;
    }

    public void Show13Mnemo()
    {
        GeneralPanelAcions.SetPanelActive(mnemo13);
    }
}