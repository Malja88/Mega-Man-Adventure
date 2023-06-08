using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFalling : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int damage;

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
