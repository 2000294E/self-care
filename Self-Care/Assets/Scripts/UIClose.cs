using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClose : MonoBehaviour
{
    public GameObject self;

    public void terminateself()
    {
        self.SetActive(false);

    }

}
