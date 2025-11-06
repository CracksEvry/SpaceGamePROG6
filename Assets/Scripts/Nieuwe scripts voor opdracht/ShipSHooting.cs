using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private Transform firePoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}