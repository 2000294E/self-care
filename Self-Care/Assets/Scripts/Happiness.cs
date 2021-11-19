using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Happiness : MonoBehaviour
{
    public Slider happy;

    public void Start()
    {
        PlayerPrefs.GetFloat("Happiness");
        SetHappy(PlayerPrefs.GetFloat("Happiness"));
    }
    //code used to set the value of the slider
    public void SetHappy(float happiness)
    {
        happy.value = happiness;
    }

}