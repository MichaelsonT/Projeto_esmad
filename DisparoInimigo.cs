using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoInimigo: MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float projectileSpeed = 10f;
    public float shootInterval = 2f;
    private float shootTimer = 0f;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {

        if (player != null && shootTimer <= 0f)
        {
            Shoot();
            shootTimer = shootInterval;
        }
        else
        {
            shootTimer -= Time.deltaTime;
        }
    }

    private void Shoot()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;

        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);

        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();

        projectileRigidbody.velocity = direction * projectileSpeed;
    }
}
