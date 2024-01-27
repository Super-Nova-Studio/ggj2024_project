using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private float spawnInterval;


    private void Start()
    {
        InvokeRepeating("SpawnWall", 0f, spawnInterval);
    }

    private void SpawnWall()
    {
        Instantiate(wall, transform.position, Quaternion.identity, this.transform);
    }
}
