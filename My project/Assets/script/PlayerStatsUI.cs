using TMPro;
using UnityEngine;

public class PlayerStatsUI : MonoBehaviour
{
    public GameObject panel;

    public TMP_Text statusText;

    public PlayerStats playerStats;

    public PlayerLevel playerLevel;

    public PlayerHealth playerHealth;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        // TAB 키로 열기/닫기
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            panel.SetActive(!panel.activeSelf);
        }

        // 창이 열려있을 때만 내용 갱신
        if (!panel.activeSelf)
            return;

        statusText.text =
            "Level : " + playerLevel.level +
            "\n\nHP : " +
            playerHealth.currentHp +
            " / " +
            playerHealth.maxHp +
            "\n\nAttack : " +
            playerStats.damageMultiplier +
            "\n\nAttack Speed : " +
            playerStats.attackSpeedMultiplier +
            "\n\nSpeed : " +
            playerStats.moveSpeed;
    }
}