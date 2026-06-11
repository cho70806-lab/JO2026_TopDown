using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPUI : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public Slider slider;

    public TMP_Text hpText;

    public float smoothSpeed = 5f;

    private float targetValue;

    private void Update()
    {
        targetValue =
            (float)playerHealth.currentHp /
            playerHealth.maxHp;

        slider.value =
            Mathf.Lerp(
                slider.value,
                targetValue,
                smoothSpeed * Time.deltaTime);

        hpText.text =
            playerHealth.currentHp +
            " / " +
            playerHealth.maxHp;
    }
}