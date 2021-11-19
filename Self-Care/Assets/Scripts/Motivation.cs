using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Motivation : MonoBehaviour
{
    public Slider motivation;

    public void Start()
    {
        PlayerPrefs.GetFloat("Motivation");
        SetMotivation(PlayerPrefs.GetFloat("Motivation"));
    }
    //code used to set the value of the slider
    public void SetMotivation(float motive)
    {
        motivation.value = motive;
    }
}
