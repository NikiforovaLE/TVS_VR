using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnemo13Animation : MonoBehaviour
{
    [SerializeField] private Animator mnemo14Animator;
    [SerializeField] private Text attentionMessage;
    private bool isChecked;
    private readonly string messageWhenNotChecked = "Проведите проверку";
    public void isSuitable()
    {
        if (isChecked)
        {
            attentionMessage.text = "";
            mnemo14Animator.Play("14 Mnemo Animation");
        } else
        {
            attentionMessage.text = messageWhenNotChecked;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isChecked = false;
        attentionMessage.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
