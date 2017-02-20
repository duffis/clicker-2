using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour {

    private static CurrencyConverter instance;
    public static CurrencyConverter Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        CreateInstance();
    }
    void CreateInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        if (valueToConvert >= 1000000000000)
        {
            converted = (valueToConvert / 1000000000000f).ToString("f2") + " T";
        }
        else if (valueToConvert >= 1000000000)
        {
            converted = (valueToConvert / 1000000000f).ToString("f2") + " B";
        }
        else if(valueToConvert>= 1000000){
            converted = (valueToConvert / 1000000f).ToString("f2") + " M";
        }
        else if (valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString("f2") + " K";
        }

        else
        {
            converted = "" + valueToConvert;
        }
        if(currencyPerSec == true)
        {
            converted = converted + " /sec";
        }
        if(currencyPerClick == true)
        {
            converted = converted + " /click";
        }
        return converted;
    }
}
