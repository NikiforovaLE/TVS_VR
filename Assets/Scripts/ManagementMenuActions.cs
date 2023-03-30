using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagementMenuActions : MonoBehaviour
{
    [SerializeField] private List<Image> buttonImagesToMakeGreen;

    private Color greenColor = new(120 / 255f, 240 / 255f, 90 / 255f);
    public void MakeButtonsGreen()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = greenColor;
        }
    }

    public void MakeButtonsWhite()
    {
        foreach (Image buttonImage in buttonImagesToMakeGreen)
        {
            buttonImage.color = Color.white;
        }
    }
}
