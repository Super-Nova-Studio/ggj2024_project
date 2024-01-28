using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] wallPrefabs;
    [SerializeField] private float spawnInterval;


    private void Start()
    {
        InvokeRepeating("SpawnWall", 0f, spawnInterval);
    }

    private void SpawnWall()
    {
        GameObject WallPrefab = wallPrefabs[Random.Range(0, wallPrefabs.Length)]; 

        Instantiate(WallPrefab, transform.position, Quaternion.identity, this.transform);
    }
}
