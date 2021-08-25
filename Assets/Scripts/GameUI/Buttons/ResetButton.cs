using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public void ResetAllValues()
    {
        CoinManagerScript.Instance.coin1Value = 0;
        CoinManagerScript.Instance.coin2Value = 0;
    }
}