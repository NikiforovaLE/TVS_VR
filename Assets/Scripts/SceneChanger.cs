using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
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
}
