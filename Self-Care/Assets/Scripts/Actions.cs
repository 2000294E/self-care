using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public Happiness happy;
    public Motivation motive;

    //adds happiness points based on what is put in the inspector
    public void ModifyHappiness(int happiness)
    {
        PlayerPrefs.SetInt("Happiness", (PlayerPrefs.GetInt("Happiness") + happiness));
        happy.SetHappy(PlayerPrefs.GetInt("Happiness"));
        Debug.Log("happiness" + PlayerPrefs.GetInt("Happiness"));
    }

    //adds motivation points based on what is put in the inspector
    public void ModifyMotivation(int motivation)
    {
        PlayerPrefs.SetInt("Motivation", (PlayerPrefs.GetInt("Motivation") + motivation));
        motive.SetMotivation(PlayerPrefs.GetInt("Motivation"));
        Debug.Log("motivaiton" + PlayerPrefs.GetInt("Motivation"));
    }

    //code to reset entire motivation value to 25 

    public void ResetMotivation(int motivation)
    {
        PlayerPrefs.SetInt("Motivation",25);
        motive.SetMotivation(PlayerPrefs.GetInt("Motivation"));
        Debug.Log("motivaiton" +PlayerPrefs.GetInt("Motivation"));
    }

    //code to reset entire happiness value to 25 
    public void ResetHappiness(int happiness)
    {
        PlayerPrefs.SetInt("Happiness", 25);
        happy.SetHappy(PlayerPrefs.GetInt("Happiness"));
        Debug.Log("happiness" + PlayerPrefs.GetInt("Happiness"));
    }
}
