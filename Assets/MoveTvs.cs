using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTvs : MonoBehaviour
{
    // Start is called before the first frame update
    int k = 0;
    public GameObject Хватайка;

    public Text хватайка;
    public Text нога;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 16)
            k = -1;
        if (transform.position.z < 8)
            k = 1;
        
        transform.position += Vector3.forward * k* Time.deltaTime;

        if (Хватайка.transform.position.y < 10)
        Хватайка.transform.position += Vector3.up * k * Time.deltaTime;


        хватайка.text = Хватайка.transform.position.y.ToString();
        нога.text = Хватайка.transform.position.z.ToString();
    }
}
