using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo01 : MonoBehaviour
{
    
    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;
    
    void Update()
    {
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript01>().shopItems[2,ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<ShopManagerScript01>().shopItems[3,ItemID].ToString();
    }
}

