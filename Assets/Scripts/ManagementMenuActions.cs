using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagementMenuActions : MonoBehaviour
{
    [SerializeField] private List<Image> buttonImagesToMakeGreen;
    [SerializeField] private Animator animator;
    [SerializeField] private Button playButton;
    [SerializeField] private Button pauseButton;
    [SerializeField] private Image unpressed;
    [SerializeField] private Image pressed;

    [SerializeField] private ManagementMenuActions managementMenuActionsOne;
    [SerializeField] private ManagementMenuActions managementMenuActionsTwo;

    private bool isChosen = false;
    private Color greenColor = new(120 / 255f, 240 / 255f, 90 / 255f);

    public bool IsChosen { get => isChosen; set => isChosen = value; }

    public void MakeButtonsGreen()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = greenColor;
        }
        IsChosen = true;
        managementMenuActionsOne.MakeButtonsWhite();
        managementMenuActionsTwo.MakeButtonsWhite();
    }

    public void MakeButtonsWhite()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = Color.white;
        }
        IsChosen = false;
    }

    public void StartOperations()
    {
        if (IsChosen)
        {
            MakeButtonOnePressedButtonTwoUnpressed(playButton, pauseButton);
            animator.enabled = true;
        }
    }

    public void StopOperations()
    {
        MakeButtonOnePressedButtonTwoUnpressed(pauseButton, playButton);
        animator.enabled = false;
    }

    private void MakeButtonOnePressedButtonTwoUnpressed(Button buttonOne, Button buttonTwo)
    {
        buttonOne.image = pressed;
        buttonTwo.image = unpressed;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator.enabled = false;
    }
}
