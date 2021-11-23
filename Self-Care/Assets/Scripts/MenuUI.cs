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
        //this check if the panel is active or not since not active returns false
        //isShowing = Panel.activeSelf;

        //Panel.SetActive will active if it is true since isShowing is false   !isShowing is true
        //Panel.SetActive(!isShowing);

        //I changed it to make it less confusing
        Panel.SetActive(true);
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
