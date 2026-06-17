using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject expGemPrefab;
    public int maxHp = 30;
    private int currentHp;

    private void Start()
    {
        currentHp = maxHp;

        EnemyManager.Instance.RegisterEnemy(this);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        KillManager.Instance.killCount++;

        SaveManager.Instance.data.totalKills++;

        Instantiate(expGemPrefab, transform.position,Quaternion.identity);

        Destroy(gameObject);
        EnemyManager.Instance.RemoveEnemy(this);

        Destroy(gameObject);

    }

    private void OnDestroy()
    {
        if (EnemyManager.Instance != null)
        {
            EnemyManager.Instance.RemoveEnemy(this);
        }
    }
}