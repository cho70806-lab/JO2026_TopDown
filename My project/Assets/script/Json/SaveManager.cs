using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;

    public SaveData data;

    private string savePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        savePath =
            Application.persistentDataPath +
            "/save.json";

        LoadGame();
    }

    public void SaveGame()
    {
        string json =
            JsonUtility.ToJson(data, true);

        File.WriteAllText(
            savePath,
            json);

        Debug.Log("저장 완료");
    }

    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            string json =
                File.ReadAllText(savePath);

            data =
                JsonUtility.FromJson<SaveData>(
                    json);

            Debug.Log("불러오기 완료");
        }
        else
        {
            data = new SaveData();

            data.gold = 0;
            data.attackLevel = 0;
            data.hpLevel = 0;
            data.totalKills = 0;
            data.playCount = 0;

            SaveGame();
        }
    }
}