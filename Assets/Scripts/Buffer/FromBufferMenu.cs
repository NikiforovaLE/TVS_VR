using UnityEngine;
using UnityEngine.UI;

public class FromBufferMenu : MonoBehaviour
{
    [SerializeField] private Text tvsAmount;
    [SerializeField] private MovingToBuffer movingToBuffer;
    public void UpdateTvsAmount()
    {
        tvsAmount.text = movingToBuffer.BufferTvsCounter.ToString();
    }
}
