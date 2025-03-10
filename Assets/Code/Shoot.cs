using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    private int health = 0;

    void Start()
    {
        AddHealth(3);

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        void AddHealth(int amount)
        {
            health += amount;
            Debug.Log("Salud actual: " + health);
        }

        void Shoot()
        {
            if (bulletPrefab != null && firePoint != null)
            {
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.linearVelocity = firePoint.forward * bulletSpeed;
                }
            }
            else
            {
                Debug.LogWarning("naonao.");
            }
        }
    }
}
