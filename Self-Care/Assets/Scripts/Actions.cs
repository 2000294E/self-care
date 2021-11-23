using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public Happiness HappyBar;
    public Motivation MotiveBar;
    public float MinHappy;
    public float MinMotive;
    public Text coinsTxt;
    public GameObject Notification;
    public Text NotificationText;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("Happiness") == 0)
        {
            PlayerPrefs.SetFloat("Happiness", 25);
        }
        if (PlayerPrefs.GetFloat("Happiness") == 0)
        {
            PlayerPrefs.SetFloat("Happiness", 25);
        }


    }

    //adds happiness points based on what is put in the inspector
    public void ModifyHappiness(float happiness)
    {
        if ((happiness > 0) == true)                                                
        {
            PlayerPrefs.SetFloat("Happiness", ((PlayerPrefs.GetFloat("Happiness") + happiness) * PlayerPrefs.GetFloat("HappyMultiplier")));
            HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
        }

        else if ((happiness < 0) == true)
        {
            if ((PlayerPrefs.GetFloat("Happiness") + happiness) >= 0)
            {
                PlayerPrefs.SetFloat("Happiness", (PlayerPrefs.GetFloat("Happiness") + happiness));
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
                Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
            }
            else if ((PlayerPrefs.GetFloat("Happiness") +    happiness) < 0)
            {
                PlayerPrefs.SetFloat("Happiness", 0);
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
                Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
            }

        }

    }

    //adds motivation points based on what is put in the inspector
    public void ModifyMotivation(float motivation)
    {
        if ((motivation > 0) == true)
        {
            PlayerPrefs.SetFloat("Motivation", ((PlayerPrefs.GetFloat("Motivation") + motivation) * PlayerPrefs.GetFloat("MotiveMultiplier")));
            MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
        }

        else if ((motivation < 0) == true)
        {
            if ((PlayerPrefs.GetFloat("Motivation") + motivation) >= 0)
            {
                PlayerPrefs.SetFloat("Motivation", (PlayerPrefs.GetFloat("Motivation") + motivation));
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
                Debug.Log("Motivation" + PlayerPrefs.GetFloat("Motivation"));
            }
            else if ((PlayerPrefs.GetFloat("Motivation") + motivation) < 0)
            {
                PlayerPrefs.SetFloat("Motivation", 0);
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
                Debug.Log("Motivation" + PlayerPrefs.GetFloat("Motivation"));
            }

        }

    }

    //code to reset entire motivation value to 25 
    public void ResetMotivation(float motivation)
    {
        PlayerPrefs.SetFloat("Motivation", 25);
        MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
        Debug.Log("motivaiton" + PlayerPrefs.GetFloat("Motivation"));
    }

    //code to reset entire happiness value to 25 
    public void ResetHappiness(float happiness)
    {
        PlayerPrefs.SetFloat("Happiness", 25);
        HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
        Debug.Log("happiness" + PlayerPrefs.GetFloat("Happiness"));
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

    public void Quest(float pay)
    {
        if (PlayerPrefs.GetFloat("Happiness") >= MinHappy && PlayerPrefs.GetFloat("Motivation") >= MinMotive)
        {
            Notification.SetActive(true);
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + pay);
            coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
            NotificationText.text = ("Congratulations you have earned $" + pay);
            Debug.Log("Passed");
        }

        else
        {
            if (PlayerPrefs.GetFloat("Happiness") < MinHappy && PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough motivation and happiness :(");
                Debug.Log("Fail");

            }

            else if (PlayerPrefs.GetFloat("Happiness") < MinHappy)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Happiness :(");
                Debug.Log("Not enough Happiness");

            }

            else if (PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Motivation :(");
                Debug.Log("Not enough Motivation");

            }

        }
    }

}
