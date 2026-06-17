using TMPro;
using UnityEngine;

public class PermanentUpgradeUI : MonoBehaviour
{
    public GameObject panel;

    public TMP_Text goldText;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            panel.SetActive(!panel.activeSelf);
        }

        goldText.text =
            "Gold : " +
            SaveManager.Instance.data.gold;
    }

    public void BuyAttackUpgrade()
    {
        if (SaveManager.Instance.data.gold < 10)
            return;

        SaveManager.Instance.data.gold -= 10;
        SaveManager.Instance.data.attackLevel++;

        SaveManager.Instance.SaveGame();
    }

    public void BuyHpUpgrade()
    {
        if (SaveManager.Instance.data.gold < 10)
            return;

        SaveManager.Instance.data.gold -= 10;
        SaveManager.Instance.data.hpLevel++;

        SaveManager.Instance.SaveGame();
    }
}