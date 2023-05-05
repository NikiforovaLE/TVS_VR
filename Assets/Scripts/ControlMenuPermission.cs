using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuPermission : MonoBehaviour
{
    [SerializeField] private ManagementMenuActions controlMenu;
    [SerializeField] private Mnemo8Animation mnemo8Animation;

    public void StartWashing()
    {
        if (mnemo8Animation.ReadyToControl && controlMenu.IsChosen)
        {
            mnemo8Animation.SetIsWashingTrue();
        }
    }
}
