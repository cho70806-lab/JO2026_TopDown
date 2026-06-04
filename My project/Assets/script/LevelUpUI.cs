using UnityEngine;

public class LevelUpUI : MonoBehaviour
{
    public static LevelUpUI Instance;

    public GameObject panel;

    private PlayerStats playerStats;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>();

        panel.SetActive(false);
    }

    public void Open()
    {
        panel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void SelectUpgrade(int type)
    {
        playerStats.ApplyUpgrade((UpgradeType)type);

        panel.SetActive(false);

        Time.timeScale = 1f;
    }
}
