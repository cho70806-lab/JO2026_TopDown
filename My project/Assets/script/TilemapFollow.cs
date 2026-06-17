using UnityEngine;

public class TilemapFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        transform.position =
            new Vector3(
                player.position.x,
                player.position.y,
                transform.position.z);
    }
}