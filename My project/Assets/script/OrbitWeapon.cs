using UnityEngine;

public class OrbitWeapon : MonoBehaviour
{
    public Transform player;

    public float orbitRadius = 2f;

    public float rotationSpeed = 180f;

    public float angle;

    private void Update()
    {
        if (player == null)
            return;

        angle += rotationSpeed * Time.deltaTime;

        float x =
            Mathf.Cos(angle * Mathf.Deg2Rad)
            * orbitRadius;

        float y =
            Mathf.Sin(angle * Mathf.Deg2Rad)
            * orbitRadius;

        transform.position =
            player.position +
            new Vector3(x, y, 0f);
    }
}