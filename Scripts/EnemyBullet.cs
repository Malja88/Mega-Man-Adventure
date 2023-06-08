using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int damage;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHP = collision.GetComponent<PlayerHealth>();
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHP.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }  
}
