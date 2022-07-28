using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float Radius = 1;

    public int index;
    private void Start()
    {   
        for (int i = 0; i < index; i++)
        {
            SpawnObjectAtRandom();
        }
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPosition = Random.insideUnitCircle * Radius;

        Instantiate(ItemPrefab, randomPosition, Quaternion.identity);
    }

    
}
