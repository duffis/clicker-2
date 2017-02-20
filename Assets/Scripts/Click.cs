using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text gpc;
    public UnityEngine.UI.Text goldDisplay;
    public float gold = 0.0f;
    public float goldPerClick = 1.0f;
    public float goldPerSec = 0.0f;

	

	void Update () {
        gpc.text = "Gold: " + goldPerClick + "/click";
        goldDisplay.text = "Gold: \n" + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
	}

    public void Clicked()
    {
        gold += goldPerClick;
    }
}
