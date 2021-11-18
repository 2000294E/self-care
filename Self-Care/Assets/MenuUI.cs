using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public GameObject Panel;
    public GameObject OpenButton;
    public GameObject CloseButton;
    private bool isShowing;

    public void OpenPanel()
    { 
        isShowing = Panel.activeSelf;
        Panel.SetActive(!isShowing);
        CloseButton.SetActive(true);
        OpenButton.SetActive(false);
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
        CloseButton.SetActive(false);
        OpenButton.SetActive(true);
    }
}
