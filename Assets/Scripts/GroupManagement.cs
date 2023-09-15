using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupManagement : MonoBehaviour
{
    [SerializeField] private Image unpressed;
    [SerializeField] private Image pressed;

    public Button groupManagementButton;
    public GameObject groupManagementMenu;
    private bool pressedState;
    public void OnClick()
    {
        groupManagementButton.image = pressedState ? pressed : unpressed;
        groupManagementMenu.SetActive(pressedState);
        pressedState = !pressedState;
    }

    // Start is called before the first frame update
    void Start()
    {
        groupManagementMenu.SetActive(false);
        pressedState = true;
    }
}
