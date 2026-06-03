using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;

    public List<EnemyHealth> enemies = new List<EnemyHealth>();

    private void Awake()
    {
        Instance = this;
    }

    public void RegisterEnemy(EnemyHealth enemy)
    {
        enemies.Add(enemy);
    }

    public void RemoveEnemy(EnemyHealth enemy)
    {
        enemies.Remove(enemy);
    }
}