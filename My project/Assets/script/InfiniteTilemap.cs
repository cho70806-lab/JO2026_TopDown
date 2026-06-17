using System.Collections.Generic;
using UnityEngine;

public class InfiniteTilemap : MonoBehaviour
{
    public Transform player;

    public GameObject tilePrefab;

    public int viewDistance = 10;

    private HashSet<Vector2Int> spawnedTiles =
        new HashSet<Vector2Int>();

    private void Update()
    {
        GenerateTiles();
    }

    void GenerateTiles()
    {
        int playerX =
            Mathf.FloorToInt(player.position.x);

        int playerY =
            Mathf.FloorToInt(player.position.y);

        for (int x = -viewDistance;
             x <= viewDistance;
             x++)
        {
            for (int y = -viewDistance;
                 y <= viewDistance;
                 y++)
            {
                Vector2Int tilePos =
                    new Vector2Int(
                        playerX + x,
                        playerY + y);

                if (!spawnedTiles.Contains(tilePos))
                {
                    Instantiate(
                        tilePrefab,
                        new Vector3(
                            tilePos.x,
                            tilePos.y,
                            0),
                        Quaternion.identity);

                    spawnedTiles.Add(tilePos);
                }
            }
        }
    }
}