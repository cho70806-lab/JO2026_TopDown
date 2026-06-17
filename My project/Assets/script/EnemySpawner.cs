using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public WaveData[] waves;

    private int currentWaveIndex;

    private float waveTimer;

    private float spawnTimer;

    private void Update()
    {
        if (currentWaveIndex >= waves.Length)
            return;

        WaveData currentWave =
            waves[currentWaveIndex];

        waveTimer += Time.deltaTime;
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= currentWave.spawnInterval)
        {
            SpawnEnemy(currentWave.enemyPrefab);

            spawnTimer = 0f;
        }

        if (waveTimer >= currentWave.duration)
        {
            currentWaveIndex++;

            waveTimer = 0f;
        }
    }

    void SpawnEnemy(GameObject enemyPrefab)
    {
        Vector2 randomPos =
            (Vector2)transform.position +
            Random.insideUnitCircle * 8f;

        Instantiate(
            enemyPrefab,
            randomPos,
            Quaternion.identity);
    }
}