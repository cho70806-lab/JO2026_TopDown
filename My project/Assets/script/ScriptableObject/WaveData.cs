using UnityEngine;

[CreateAssetMenu(fileName = "WaveData",
                 menuName = "Game/Wave Data")]
public class WaveData : ScriptableObject
{
    public string waveName;

    public float duration;

    public float spawnInterval;

    public GameObject enemyPrefab;
}