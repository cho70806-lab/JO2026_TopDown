using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f;

    private Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (player == null) return;

        Vector2 dir =
            (player.position - transform.position).normalized;

        rb.MovePosition(
            rb.position + dir * moveSpeed * Time.fixedDeltaTime
        );
    }
}