using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // prefab do obstáculo (ex: cacto)
    public float spawnXPosition = 10f; // posição fixa no eixo X pra spawnar
    public float minSpawnDelay = 1.5f; // intervalo mínimo entre spawn
    public float maxSpawnDelay = 3f;   // intervalo máximo entre spawn

    private float nextSpawnTime;

    void Start()
    {
        // Define o primeiro spawn para logo
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(spawnXPosition, -3.2f, 0f); // altura certa do chão
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
