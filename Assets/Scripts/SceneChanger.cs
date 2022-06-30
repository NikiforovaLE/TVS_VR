using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ChangeScene(string scenename) { 
        SceneManager.LoadScene(scenename); 
    }

    public void ClickAnimation()
    {
        ChangeScene("TBC");
    }

    public void ClickMenu()
    {
        ChangeScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
