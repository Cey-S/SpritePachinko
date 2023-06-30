using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Chest : MonoBehaviour
{
    public int ID;
    [SerializeField] private Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private bool isChestEmpty;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        isChestEmpty = true;
    }

    private void SetChestToFull(int id)
    {
        if (id.Equals(ID) && isChestEmpty)
        {
            spriteRenderer.sprite = sprites[1];

            isChestEmpty = false;
        }
    }

    private void OnEnable()
    {
        Coin.CollideWithChest += SetChestToFull;
    }

    private void OnDisable()
    {
        Coin.CollideWithChest -= SetChestToFull;
    }
}
