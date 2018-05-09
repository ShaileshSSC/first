using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnThreshold = 0.1f;
    public float spawnWidth = 2.3f;

    private float spawnTimer = 0;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
        }
    }

    private void SpawnCube()
    {
        // programmeer een random positie op de x-as
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnWidth, spawnWidth), transform.position.y, transform.position.z);
        var cubis = Instantiate(cubePrefab, spawnPosition, transform.rotation);

        spawnTimer = 0;
    }
}