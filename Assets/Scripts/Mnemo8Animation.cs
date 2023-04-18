using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo8Animation : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private GameObject TVS;
    [SerializeField] private Text currentTVSNumberText;
    [SerializeField] private Animator mnemo08Animator;
    public ARM2Mnemo0 aRM2Mnemo0;
    private bool isWashing = false;
    private readonly Vector3 washingTarget = new(361, -270, 0);

    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentTVSNumberText.text = "";
        TVS.transform.position = new Vector3(486f, -269f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTVSNumberText.text = aRM2Mnemo0.FrameNumber.text;
        if (isWashing)
        {
            TVS.transform.position = Vector3.MoveTowards(TVS.transform.position, washingTarget, speed * Time.deltaTime);
            if (TVS.transform.position == washingTarget)
            {
                isWashing = false;
            }

        }
    }

    public void MoveToBufferStore()
    {
        Manipulator.transform.Translate((new Vector3(-374f, 123f)));
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(-374f, -269f));
    }

    public void MoveFromBufferStore(GameObject target)
    {
        Manipulator.transform.Translate(target.transform.position);
        TVS.transform.Translate(target.transform.position);
    }

    public void MoveToAssembly()
    {
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(0f, -170f, 0f));
    }    
    
    public void MoveFromAssembly()
    {
        TVS.transform.Translate(speed * Time.deltaTime * new Vector3(485f, -270f, 0f));
    }

    public void MoveToWashing()
    {
        isWashing = true;
        //mnemo08Animator.Play("08 Mnemo Animation Washing");
    }
}
