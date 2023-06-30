using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnPosY = 4.28f;
    [SerializeField] private float spawnPosX = 6.6f;
    [SerializeField] private float spawnDelay = 3.0f;

    private WaitForSeconds spawnRoutineDelay;

    private void Start()
    {
        spawnRoutineDelay = new WaitForSeconds(spawnDelay);

        StartCoroutine(SpawnRoutine());
    }
    IEnumerator SpawnRoutine()
    {
        Vector2 spawnPos = Vector2.zero;

        while (true)
        {
            spawnPos.x = Random.Range(-spawnPosX, spawnPosX);
            spawnPos.y = spawnPosY;

            GameObject coin = ObjectPool.SharedInstance.GetPooledObject();
            if (coin != null)
            {
                coin.transform.position = spawnPos;
                coin.SetActive(true);
            }

            yield return spawnRoutineDelay;
        }
    }
}
