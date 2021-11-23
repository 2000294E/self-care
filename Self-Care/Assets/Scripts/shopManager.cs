using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shopManager : MonoBehaviour
{
    public Text coinsTxt;
    public int coins;
    public Button item;
    public GameObject Notification;
    public Text NotificationText;
    public string ItemName;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("money", coins);
        coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");

    }


    public void Buy(float price)
    {
        if (PlayerPrefs.GetFloat("money") >= price)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - price);
            coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
            Notification.SetActive(true);
            NotificationText.text = ("You have successfully purchased " + ItemName);
            item.interactable = false;

        }
        else if (PlayerPrefs.GetFloat("money") < price)
        {
            Notification.SetActive(true);
            NotificationText.text = ("You need $" + (price -(PlayerPrefs.GetFloat("money"))) + (" more to buy ") + ItemName);
            Debug.Log("Not enough Money");
        }
    }
}
