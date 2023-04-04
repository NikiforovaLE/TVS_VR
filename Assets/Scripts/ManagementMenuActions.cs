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
    private bool isChosen = false;
    private Color greenColor = new(120 / 255f, 240 / 255f, 90 / 255f);
    public void MakeButtonsGreen()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = greenColor;
        }
        isChosen = true;
    }

    public void MakeButtonsWhite()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = Color.white;
        }
        isChosen = false;
    }

    public void StartOperations()
    {
        if (isChosen)
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
