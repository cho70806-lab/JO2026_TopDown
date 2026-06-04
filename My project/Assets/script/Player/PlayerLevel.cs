using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;

    public int currentExp = 0;
    public int maxExp = 50;

    public void GainExp(int amount)
    {
        currentExp += amount;

        if (currentExp >= maxExp)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        level++;

        currentExp -= maxExp;

        maxExp += 25;

        Debug.Log("레벨업! 현재 레벨 : " + level);

        LevelUpUI.Instance.Open();
    }
}