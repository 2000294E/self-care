using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionType : MonoBehaviour
{

    public GameObject Open;
    public GameObject Close1;
    public GameObject Close2;
    public GameObject Close3;

    public void PanelSelect()
    {
        Open.SetActive(true);
        Close1.SetActive(false);
        Close2.SetActive(false);
        Close3.SetActive(false);

    }
}
