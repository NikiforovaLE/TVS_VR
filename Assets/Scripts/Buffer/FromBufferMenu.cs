using UnityEngine;
using UnityEngine.UI;

public class FromBufferMenu : MonoBehaviour
{
    [SerializeField] private Text tvsAmount;
    [SerializeField] private Image bufferIndicator;
    [SerializeField] private Image bufferIndicatorOnMnemo00;

    private const int SIZE = 4;
    [SerializeField] private Text[] tvsNumberCells = new Text[SIZE];
    [SerializeField] private GameObject[] tvsCells = new GameObject[SIZE];
    [SerializeField] private GameObject[] innerWhenTvs = new GameObject[SIZE];

    private int bufferTvsCounter = 0;

    public int BufferTvsCounter { get => bufferTvsCounter; set => bufferTvsCounter = value; }

    void OnValidate()
    {
        if (tvsNumberCells.Length != SIZE || tvsCells.Length != SIZE || innerWhenTvs.Length != SIZE)
        {
            Debug.LogWarning("Don't change the array's size!");
            System.Array.Resize(ref tvsNumberCells, SIZE);
            System.Array.Resize(ref tvsCells, SIZE);
            System.Array.Resize(ref innerWhenTvs, SIZE);
        }
    }

    public void AddTvsToBuffer(string tvsNumber)
    {
        tvsNumberCells[BufferTvsCounter].text = tvsNumber;
        tvsCells[BufferTvsCounter].GetComponent<Image>().color = Color.green;
        tvsCells[BufferTvsCounter].transform.GetChild(0).GetComponent<Image>().color = Color.green;
        innerWhenTvs[BufferTvsCounter].SetActive(true);
        tvsAmount.text = (++BufferTvsCounter).ToString();
    }

    public void RemoveTvsFromBuffer()
    {
        tvsAmount.text = (--BufferTvsCounter).ToString();
        tvsNumberCells[BufferTvsCounter].text = "";
        ConfigureBufferIndicator();
        tvsCells[BufferTvsCounter].GetComponent<Image>().color = Color.white;
        tvsCells[BufferTvsCounter].transform.GetChild(0).GetComponent<Image>().color = Color.white;
        innerWhenTvs[BufferTvsCounter].SetActive(false);
    }

    private void ConfigureBufferIndicator()
    {
        if (BufferTvsCounter == 0)
        {
            bufferIndicator.color = Color.white;
            bufferIndicatorOnMnemo00.color = Color.white;
        }
    }
}
