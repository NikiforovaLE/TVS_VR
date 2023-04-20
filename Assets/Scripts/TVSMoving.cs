using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVSMoving : MonoBehaviour
{
    public Mnemo8Animation Mnemo8Animation;
    private bool isWashing;
    private readonly Vector3 washingTarget = new Vector3(361.0f, -270.0f, 0.0f);
    private readonly float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isWashing = Mnemo8Animation.IsWashing;
        if (isWashing)
        {
            Vector3 currentTVSPosition = transform.position;
            transform.position = Vector3.MoveTowards(currentTVSPosition, washingTarget, Time.deltaTime * speed);
        }
    }
}
