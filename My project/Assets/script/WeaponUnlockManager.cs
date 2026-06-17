using UnityEngine;

public class WeaponUnlockManager : MonoBehaviour
{
    public GameObject swordGroup;

    public void UnlockSword()
    {
        swordGroup.SetActive(true);

        Debug.Log("È¸Àü °Ë È¹µæ!");
    }
}