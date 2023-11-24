using UnityEngine;

public class BufferButton : MonoBehaviour
{
    public GameObject bufferButtonMenu;
    private bool pressedState;
    public void ShowBufferMenu()
    {
        bufferButtonMenu.SetActive(pressedState);
        pressedState = !pressedState;
    }

    // Start is called before the first frame update
    void Start()
    {
        bufferButtonMenu.SetActive(false);
        pressedState = true;
    }
}
