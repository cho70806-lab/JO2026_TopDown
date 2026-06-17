using UnityEngine;

public class ExpGem : MonoBehaviour
{
    public int expAmount = 10;

    public float moveSpeed = 10f;

    private Transform player;

    private bool isMagnetized = false;

    private void Start()
    {
        GameObject playerObj =
            GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    private void Update()
    {
        if (player == null)
            return;

        if (isMagnetized)
        {
            transform.position =
                Vector2.MoveTowards(
                    transform.position,
                    player.position,
                    moveSpeed * Time.deltaTime);
        }
    }

    public void Magnetize()
    {
        isMagnetized = true;
    }
}