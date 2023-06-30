using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public delegate void OnCountChange();
    public static event OnCountChange IncreaseCoinCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseCoinCount?.Invoke();
        Destroy(gameObject);
    }
}
