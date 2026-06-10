using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarUI : MonoBehaviour
{
    public PlayerLevel playerLevel;

    public Slider slider;

    public TMP_Text levelText;

    public TMP_Text expText;

    public float smoothSpeed = 5f;

    private float targetValue;

    private void Start()
    {
        if (slider == null)
            slider = GetComponent<Slider>();

        targetValue = slider.value;
    }

    private void Update()
    {
        targetValue =
            (float)playerLevel.currentExp /
            playerLevel.maxExp;

        slider.value =
            Mathf.Lerp(
                slider.value,
                targetValue,
                smoothSpeed * Time.deltaTime);

        levelText.text =
            "Lv. " + playerLevel.level;

        expText.text =
            playerLevel.currentExp +
            " / " +
            playerLevel.maxExp;
    }
}