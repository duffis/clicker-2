using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPerSecond : MonoBehaviour {

    public UnityEngine.UI.Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    public void Start()
    {
        StartCoroutine(AutoTick());
    }
    public void Update()
    {
        gpsDisplay.text = "Gold: " + getGoldPerSec() + "/sec";
    }

    public float getGoldPerSec()
    {
        float tick = 0;
        float multiplier = 1;
        foreach(ItemManager item in items)
        {
            multiplier = Mathf.Pow(2, (item.count / 25));
            tick += item.count * item.tickValue * multiplier;
        }
        return tick;
    }

    public void AutoGoldPerSec()
    {
        click.gold += getGoldPerSec() / 10;
    }
    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }
    
}
