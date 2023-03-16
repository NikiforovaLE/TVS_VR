using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo12Animation : MonoBehaviour
{
    [SerializeField] private Text isDoneText;

    private readonly string done = "Выполнен";
    // Start is called before the first frame update
    void Start()
    {
        isDoneText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsDone()
    {
        isDoneText.text = done;
    }
}
