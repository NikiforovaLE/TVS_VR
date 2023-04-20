using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo8Animation : MonoBehaviour
{
    [SerializeField] private GameObject Manipulator;
    [SerializeField] private Image TVS;
    [SerializeField] private Text currentTVSNumberText;
    [SerializeField] private Animator mnemo08Animator;
    public ARM2Mnemo0 aRM2Mnemo0;
    private bool isWashing = false;
    private readonly Vector3 washingTarget = new(361.0f, -270.0f, 0.0f);
    private readonly float speed = 1.0f;

    public bool IsWashing { get => isWashing; set => isWashing = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentTVSNumberText.text = "";
        TVS.transform.position = new Vector3(486f, -270f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTVSNumberText.text = aRM2Mnemo0.FrameNumber.text;
        if (IsWashing)
        {
            mnemo08Animator.enabled = false;
            MoveManipulatorToWashing();
            TVS.rectTransform.anchoredPosition.Set(361.0f, -270.0f);
            if (TVS.transform.position.Equals(washingTarget))
            {
                isWashing = false;
            }
        }
    }

    private void MoveManipulatorToWashing()
    {
        //Manipulator.transform.Translate(Manipulator.transform.position);

        //move towards the center of the world (or where ever you like)
        Vector3 targetPosition = new Vector3(362.3f, -173.7f, 0.0f);

        Vector3 currentPosition = Manipulator.transform.position;
        //first, check to see if we're close enough to the target
        if (Vector3.Distance(currentPosition, targetPosition) > 1f)
        {
            Vector3 directionOfTravel = targetPosition - currentPosition;
            directionOfTravel.Normalize();
            //scale the movement on each axis by the directionOfTravel vector components

            Manipulator.transform.Translate(
                (directionOfTravel.x * speed * Time.deltaTime),
                (directionOfTravel.y * speed * Time.deltaTime), 0.0f);
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
        IsWashing = true;

        //mnemo08Animator.Play("08 Mnemo Animation Washing");
    }
}
