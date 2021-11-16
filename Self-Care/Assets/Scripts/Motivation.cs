using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Motivation : MonoBehaviour
{
    public Slider motivation;

    //code used to set the value of the slider
    public void SetMotivation(int motive)
    {
        motivation.value = motive;
    }
}
