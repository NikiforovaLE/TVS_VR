using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARM1 : MonoBehaviour
{
    public GameObject obj;
    public KeyCode onClose;

    void Close()
    {
        obj.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(onClose))
        {
            (new ARM1()).Close();
        }
    }
}
