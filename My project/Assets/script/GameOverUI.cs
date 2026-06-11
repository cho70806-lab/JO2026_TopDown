using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI Instance;

    public GameObject panel;

    public TMP_Text levelText;
    public TMP_Text timeText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowGameOver(int level, string time)
    {
        panel.SetActive(true);

        levelText.text =
            "최종 레벨 : " + level;

        timeText.text =
            "생존 시간 : " + time;

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex);
    }
}