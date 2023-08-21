using System;
using UnityEngine;
using UnityEngine.UI;

public class DataGetter : MonoBehaviour
{
    [SerializeField] private Text data;
    private void SetData()
    {
        data.text = DateTime.Now.AddDays(3).ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
