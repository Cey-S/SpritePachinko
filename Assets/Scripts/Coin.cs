using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float YPosBoundary;

    public delegate void OnCountChange();
    public static event OnCountChange IncreaseCoinCount;

    private void Update()
    {
        if (transform.position.y < YPosBoundary)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseCoinCount?.Invoke();
        gameObject.SetActive(false); // return to the pool
    }
}
