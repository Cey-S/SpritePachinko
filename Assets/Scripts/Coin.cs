using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float YPosBoundary;

    public delegate void OnCountChange();
    public static event OnCountChange IncreaseCoinCount;

    public delegate void OnInteraction(int id);
    public static event OnInteraction CollideWithChest;

    private void Update()
    {
        if (transform.position.y < YPosBoundary)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollideWithChest?.Invoke(collision.GetComponent<Chest>().ID);
        IncreaseCoinCount?.Invoke();
        gameObject.SetActive(false); // return to the pool
    }
}
