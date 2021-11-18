using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public Happiness happy;
    public Motivation motive;
    public float happinessMultiply;
    public float motiveMultiply;


    public void MotiveMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("MotiveMultiplier", (PlayerPrefs.GetFloat("MotiveMultiplier") + motive));
    }

    public void HappyMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("HappyMultiplier", (PlayerPrefs.GetFloat("HappyMultiplier") + motive));
    }

    //adds happiness points based on what is put in the inspector
    public void ModifyHappiness(float happiness)
    {
        if (happiness >0)
        {
            PlayerPrefs.SetFloat("Happiness", ((PlayerPrefs.GetFloat("Happiness") + happiness) * PlayerPrefs.GetFloat("MotiveMultiplier")));
            happy.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
        }
        else if (happiness < 0)
        {
            PlayerPrefs.SetFloat("Happiness", (PlayerPrefs.GetFloat("Happiness") + happiness));
            happy.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
        }

    }

    //adds motivation points based on what is put in the inspector
    public void ModifyMotivation(float motivation)
    {
        if (motivation > 0)
        {
            PlayerPrefs.SetFloat("Motivation", ((PlayerPrefs.GetFloat("Motivation") + motivation) * PlayerPrefs.GetFloat("HappyMultiplier")));
            motive.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
        }
        else if(motivation < 0)
        {
            PlayerPrefs.SetFloat("Motivation", (PlayerPrefs.GetFloat("Motivation") + motivation));
            motive.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
        }

    }

    //code to reset entire motivation value to 25 

    public void ResetMotivation(float motivation)
    {
        PlayerPrefs.SetFloat("Motivation",25);
        motive.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
        Debug.Log("motivaiton" +PlayerPrefs.GetFloat("Motivation"));
    }

    //code to reset entire happiness value to 25 
    public void ResetHappiness(float happiness)
    {
        PlayerPrefs.SetFloat("Happiness", 25);
        happy.SetHappy(PlayerPrefs.GetFloat("Happiness"));
        Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
    }
}
