using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Happiness : MonoBehaviour
{
    public Slider happy;

    //code used to set the value of the slider
    public void SetHappy(int happiness)
    {
        happy.value = happiness;
    }

}

