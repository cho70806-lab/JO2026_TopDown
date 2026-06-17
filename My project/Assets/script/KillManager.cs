using UnityEngine;

public class KillManager : MonoBehaviour
{
    public static KillManager Instance;

    public int killCount;

    private void Awake()
    {
        Instance = this;
    }
}