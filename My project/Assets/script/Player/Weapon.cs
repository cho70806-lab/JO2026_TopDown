using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float attackRange = 8f;
    public GameObject bulletPrefab;
    public float attackInterval = 0.5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= attackInterval)
        {
            Attack();
            timer = 0f;
        }
    }

    void Attack()
    {
        GameObject target = FindClosestEnemy();

        if (target == null)
            return;

        GameObject bullet =
            Instantiate(
                bulletPrefab,
                transform.position,
                Quaternion.identity);

        bullet.GetComponent<Bullet>().SetTarget(target.transform);
    }

    GameObject FindClosestEnemy()
    {
        EnemyHealth closestEnemy = null;
        float minDistance = Mathf.Infinity;

        foreach (EnemyHealth enemy in EnemyManager.Instance.enemies)
        {
            if (enemy == null)
                continue;

            float distance =
                Vector2.Distance(
                    transform.position,
                    enemy.transform.position);

            if (distance < minDistance &&
                distance <= attackRange)
            {
                minDistance = distance;
                closestEnemy = enemy;
            }
        }

        return closestEnemy != null
            ? closestEnemy.gameObject
            : null;
    }
}