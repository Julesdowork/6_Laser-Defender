﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Enemy Wave Configuration")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float spawnRate = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numEnemies = 10;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEnemyPrefab() { return enemyPrefab; }

    public List<Transform> GetWaypoints()
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }
    
    public float GetSpawnRate() { return spawnRate; }
    
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }
    
    public int GetNumberOfEnemies() { return numEnemies; }
    
    public float GetMoveSpeed() { return moveSpeed; }


}
