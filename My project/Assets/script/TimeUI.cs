using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    public TMP_Text timeText;

    private float elapsedTime;

    public string GetFormattedTime()
    {
        int minutes =
            Mathf.FloorToInt(elapsedTime / 60);

        int seconds =
            Mathf.FloorToInt(elapsedTime % 60);

        return string.Format(
            "{0:00}:{1:00}",
            minutes,
            seconds);
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;

        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        timeText.text =
            string.Format("{0:00}:{1:00}",
            minutes,
            seconds);
    }
}