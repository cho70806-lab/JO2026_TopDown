using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI Instance;

    public GameObject panel;

    public TMP_Text levelText;
    public TMP_Text timeText;
    public TMP_Text killText;
    public TMP_Text goldText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowGameOver(
     int level,
     string time)
    {
        panel.SetActive(true);

        levelText.text =
            "Level : " + level;

        timeText.text =
            "Time : " + time;

        killText.text =
            "Kills : " +
            KillManager.Instance.killCount;

        goldText.text =
            "Gold : " +
            KillManager.Instance.killCount;

        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex);
    }
}