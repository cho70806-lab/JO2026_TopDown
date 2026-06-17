using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;

    private void Start()
    {
        maxHp +=
            SaveManager.Instance.data.hpLevel * 10;

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
        int earnedGold =
            SaveManager.Instance.data.totalKills;

        SaveManager.Instance.data.gold += earnedGold;

        SaveManager.Instance.data.playCount++;

        SaveManager.Instance.SaveGame();

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