using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("적 프리팹")]
    public GameObject enemyPrefab;

    [Header("플레이어")]
    public Transform player;

    [Header("스폰 설정")]
    public float spawnInterval = 2f;
    public float spawnDistance = 10f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        // 원형 범위 랜덤 위치
        Vector2 randomDir = Random.insideUnitCircle.normalized;

        Vector3 spawnPos = player.position +
                           new Vector3(randomDir.x, randomDir.y, 0) *
                           spawnDistance;

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
