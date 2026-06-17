using UnityEngine;
using UnityEngine.UI;

public class OptionUI : MonoBehaviour
{
    public GameObject panel;

    public Slider bgmSlider;

    public AudioSource bgmSource;

    private void Start()
    {
        panel.SetActive(false);

        float volume =
            PlayerPrefs.GetFloat(
                "BGMVolume",
                1f);

        bgmSlider.value = volume;

        bgmSource.volume = volume;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(!panel.activeSelf);
        }
    }

    public void SaveBGMVolume()
    {
        PlayerPrefs.SetFloat(
            "BGMVolume",
            bgmSlider.value);

        PlayerPrefs.Save();

        bgmSource.volume =
            bgmSlider.value;
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}