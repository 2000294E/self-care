using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shopManager : MonoBehaviour
{

    public Text coinsTxt;
    //public int coins;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("money", coins);
        coinsTxt.text = "Money: $" +   PlayerPrefs.GetFloat("money");

    }


    public void Buy(float price)
    {
        PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - price);
        coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
    }
}
