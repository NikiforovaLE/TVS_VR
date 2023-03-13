using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mnemo8Animation : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private GameObject TVS;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToBufferStore()
    {
        Manipulator.transform.Translate((new Vector3(-374f, 123f)));
        TVS.transform.Translate((new Vector3(-374f, -269f)));
    }

    public void MoveFromBufferStore(GameObject target)
    {
        Manipulator.transform.Translate(target.transform.position);
        TVS.transform.Translate(target.transform.position);
    }
}
