using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanelActions : MonoBehaviour
{
    [SerializeField] private GameObject mnemoOneImage;
    [SerializeField] private GameObject mnemoTwoImage;
    [SerializeField] private GameObject mnemoThreeImageOne;
    [SerializeField] private GameObject mnemoThreeImageTwo;
    [SerializeField] private GameObject mnemoFourImage;
    // Start is called before the first frame update
    void Start()
    {
        mnemoOneImage.SetActive(false);
        mnemoTwoImage.SetActive(false);
        mnemoThreeImageOne.SetActive(false);
        mnemoThreeImageTwo.SetActive(false);
        mnemoFourImage.SetActive(false);
    }
}
