using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private float spawnInterval;

    private void OnEnable()
    {
        GameManager.Instance.OnStateChanged += HandleGameStateChanged;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnStateChanged -= HandleGameStateChanged;
    }

    private void HandleGameStateChanged(object sender, EventArgs e)
    {
        if (GameManager.Instance.IsGamePlaying())
        {
            StartSpawning();
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnWall", 0f, spawnInterval);
    }

    private void SpawnWall()
    {
        Instantiate(wall, transform.position, Quaternion.identity, this.transform);
    }
}