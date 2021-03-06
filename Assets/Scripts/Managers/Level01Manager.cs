﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Manager : MonoBehaviour
{
    public Transform[] badSpawn;

    public GameObject badPrefab;

    public int badWaves = 3;

    public float waitTimeFistWave = 3f;

    public float waitTimeBetweenWaves = 10f;

    void Start()
    {
        StartCoroutine(SpawnBad());
    }

    IEnumerator SpawnBad()
    {
        yield return new WaitForSeconds(waitTimeFistWave);
        for (int i = 0; i < badWaves; i++)
        {
            for (int j = 0;j <badSpawn.Length; j++)
            {
                Instantiate(badPrefab, badSpawn[j].position, Quaternion.identity);
            }
            yield return new WaitForSeconds(waitTimeBetweenWaves);
        }
    }
}
