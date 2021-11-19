using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public Happiness happy;
    public Motivation motive;

    //adds happiness points based on what is put in the inspector
    public void ModifyHappiness(float happiness)
    {
        if ((happiness > 0) == true)
        {
            PlayerPrefs.SetFloat("Happiness", ((PlayerPrefs.GetFloat("Happiness") + happiness) * PlayerPrefs.GetFloat("MotiveMultiplier")));
            happy.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
        }

        else if ((happiness < 0) == true)
        {
            PlayerPrefs.SetFloat("Happiness", (PlayerPrefs.GetFloat("Happiness") + happiness));
            happy.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
        }

    }

    //adds motivation points based on what is put in the inspector
    public void ModifyMotivation(float motivation)
    {
        if ((motivation > 0) == true)
        {
            PlayerPrefs.SetFloat("Motivation", ((PlayerPrefs.GetFloat("Motivation") + motivation) * PlayerPrefs.GetFloat("HappyMultiplier")));
            motive.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
        }

        else if ((motivation < 0) == true)
        {
            PlayerPrefs.SetFloat("Motivation", (PlayerPrefs.GetFloat("Motivation") + motivation));
            motive.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
        }

    }

    public void MotiveMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("MotiveMultiplier", (PlayerPrefs.GetFloat("MotiveMultiplier") + motive));
        Debug.Log("motive multiplier in effect is " + PlayerPrefs.GetFloat("MotiveMultiplier"));
    }

    public void HappyMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("HappyMultiplier", (PlayerPrefs.GetFloat("HappyMultiplier") + motive));
        Debug.Log("happiness multiplier in effect is " + PlayerPrefs.GetFloat("HappyMultiplier"));
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

    public void ResetMotiveMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("MotiveMultiplier", 1);
        Debug.Log("motive multiplier in reset to " + PlayerPrefs.GetFloat("MotiveMultiplier"));
    }

    public void ResetHappyMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("HappyMultiplier", 1);
        Debug.Log("happiness multiplier is reset to " + PlayerPrefs.GetFloat("HappyMultiplier"));
    }

}
