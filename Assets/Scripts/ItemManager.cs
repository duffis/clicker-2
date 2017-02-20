using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public GoldPerSecond gps;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    public float basecost;
    public Color standard;
    public Color canBuy;

    public void Start()
    {
        basecost = cost;
    }
    public void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\nKoszt: " + cost + "\nGold: " +  gps.getGoldPerSec()  + "/s";

        if(click.gold >= cost)
        {
            GetComponent<Image>().color = canBuy;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    public void PurchasedItem()
    {
        if(click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round(basecost * Mathf.Pow(1.15f, count));
        }
    }
}
