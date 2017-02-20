using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;

    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float baseCost;
    public Color standard;
    public Color canBuy;

    private void Start()
    {
        baseCost = cost;
    }

    public void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\nKoszt: " + cost + "\nPower: +" + clickPower;

        if(click.gold <= cost)
        {
            GetComponent<Image>().color = standard;
        }
        else
        {
            GetComponent<Image>().color = canBuy;
        }
    }

    public void PurchasedUpgrade()
    {
        if(click.gold >= cost)
        {
            click.gold -= cost;
            count++;
            click.goldPerClick += clickPower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.45f, count));
        }
    }
}
