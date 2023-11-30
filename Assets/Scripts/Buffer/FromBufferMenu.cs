using UnityEngine;
using UnityEngine.UI;

public class FromBufferMenu : MonoBehaviour
{
    [SerializeField] private Text tvsAmount;
    [SerializeField] private Image bufferIndicator;

    [HideInInspector] private const int SIZE = 4;
    [SerializeField] private Text[] tvsNumberCells = new Text[SIZE];
    [SerializeField] private Image[] tvsCellImages = new Image[SIZE];
    [SerializeField] private GameObject[] innerWhenTvsImages = new GameObject[SIZE];

    private int bufferTvsCounter = 0;

    public int BufferTvsCounter { get => bufferTvsCounter; set => bufferTvsCounter = value; }

    void OnValidate()
    {
        if (tvsCellImages.Length != SIZE || innerWhenTvsImages.Length != SIZE)
        {
            Debug.LogWarning("Don't change the array's size!");
            System.Array.Resize(ref tvsCellImages, SIZE);
            System.Array.Resize(ref innerWhenTvsImages, SIZE);
        }
    }

    public void AddTvsToBuffer(string tvsNumber)
    {
        tvsNumberCells[BufferTvsCounter].text = tvsNumber;
        tvsCellImages[BufferTvsCounter].color = Color.green;
        tvsCellImages[BufferTvsCounter].GetComponentInChildren<Image>().color = Color.green;
        innerWhenTvsImages[BufferTvsCounter].SetActive(true);
        tvsAmount.text = (++BufferTvsCounter).ToString();
    }

    public void RemoveTvsFromBuffer()
    {
        tvsAmount.text = (--BufferTvsCounter).ToString();
        tvsNumberCells[BufferTvsCounter].text = "";
        if (BufferTvsCounter == 0)
        {
            bufferIndicator.color = Color.green;
        }
    }
}
