using UnityEngine;

public class Mnemo06Animation : MonoBehaviour
{
    private Animation animmnemo06;
    public Animator Manipulator;

    // Start is called before the first frame update
    void Start()
    {
        animmnemo06 = gameObject.GetComponent<Animation>();
    }

    public void ManipulatorRun()
    {
        Manipulator.Play("Armature_Action_Event", 0, 0f);
        Manipulator.speed = 1;
    }

    public void ManipulatorStop()
    {
        animmnemo06.Stop();
        Manipulator.enabled = false;
    }
}
