using UnityEngine;

public class PlayerMagnet : MonoBehaviour
{
    public float magnetRadius = 3f;

    private void Update()
    {
        Collider2D[] gems =
            Physics2D.OverlapCircleAll(
                transform.position,
                magnetRadius);

        foreach (Collider2D gem in gems)
        {
            if (gem.CompareTag("ExpGem"))
            {
                ExpGem expGem =
                    gem.GetComponent<ExpGem>();

                if (expGem != null)
                {
                    expGem.Magnetize();
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(
            transform.position,
            magnetRadius);
    }
}