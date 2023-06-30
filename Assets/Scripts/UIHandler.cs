using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Text coinCountText;

    private int coinCount = 0;

    private void IncreaseCoinCount()
    {
        coinCount++;
        coinCountText.text = $"Coin Count: {coinCount}";
    }

    private void OnEnable()
    {
        Coin.IncreaseCoinCount += IncreaseCoinCount;
    }

    private void OnDisable()
    {
        Coin.IncreaseCoinCount -= IncreaseCoinCount;
    }
}
