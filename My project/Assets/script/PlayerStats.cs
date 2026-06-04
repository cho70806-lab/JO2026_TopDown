using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float damageMultiplier = 1f;

    public float attackSpeedMultiplier = 1f;

    public void ApplyUpgrade(UpgradeType type)
    {
        switch (type)
        {
            case UpgradeType.Damage:
                damageMultiplier += 0.2f;
                Debug.Log("공격력 배율 : " + damageMultiplier);
                break;

            case UpgradeType.AttackSpeed:
                attackSpeedMultiplier += 0.15f;
                Debug.Log("공격속도 배율 : " + attackSpeedMultiplier);
                break;

            case UpgradeType.MoveSpeed:
                moveSpeed += 1f;
                Debug.Log("이동속도 : " + moveSpeed);
                break;
        }
    }
}
