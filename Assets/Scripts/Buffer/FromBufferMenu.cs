using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FromBufferMenu : MonoBehaviour
{
    [SerializeField] private Text tvsAmount;
    [SerializeField] private Text tvsCellOne;
    [SerializeField] private Text tvsCellTwo;
    [SerializeField] private Text tvsCellThree;
    [SerializeField] private Text tvsCellFour;
    [SerializeField] private Image bufferIndicator;

    private int bufferTvsCounter = 0;
    private List<Text> tvsCells;

    public int BufferTvsCounter { get => bufferTvsCounter; set => bufferTvsCounter = value; }

    public void AddTvsToBuffer(string tvsNumber)
    {
        tvsCells[BufferTvsCounter].text = tvsNumber;
        tvsAmount.text = (++BufferTvsCounter).ToString();
    }

    public void RemoveTvsFromBuffer()
    {
        tvsAmount.text = (--BufferTvsCounter).ToString();
        tvsCells[BufferTvsCounter].text = "";
        if(BufferTvsCounter == 0)
        {
            bufferIndicator.color = new(255f, 255f, 255f, 255f);
        }
    }

    // Start is called before the first frame update
    void Start() => tvsCells = new List<Text> { tvsCellTwo, tvsCellOne, tvsCellThree, tvsCellFour };
}
