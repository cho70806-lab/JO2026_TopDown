using TMPro;
using UnityEngine;

public class KillUI : MonoBehaviour
{
    public TMP_Text killText;

    private void Update()
    {
        killText.text =
            "Kills : " +
            KillManager.Instance.killCount;
    }
}