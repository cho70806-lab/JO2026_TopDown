using UnityEngine;

public class ExpGem : MonoBehaviour
{
    public int expAmount = 10;

    public float moveSpeed = 10f;

    private Transform player;

    private bool isMagnetized = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
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