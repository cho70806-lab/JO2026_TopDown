using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;

    private void Start()
    {
        
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        Debug.Log("현재 체력 : " + currentHp);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("게임 오버");

        PlayerLevel playerLevel =
            GetComponent<PlayerLevel>();

        TimeUI timeUI =
            FindFirstObjectByType<TimeUI>();

        GameOverUI.Instance.ShowGameOver(
            playerLevel.level,
            timeUI.GetFormattedTime());

        gameObject.SetActive(false);
    }
}