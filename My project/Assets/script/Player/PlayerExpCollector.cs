using UnityEngine;

public class PlayerExpCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ExpGem"))
        {
            ExpGem gem = other.GetComponent<ExpGem>();

            GetComponent<PlayerLevel>()
                .GainExp(gem.expAmount);

            Destroy(other.gameObject);
        }
    }
}