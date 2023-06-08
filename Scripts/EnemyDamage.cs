using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private Vector2 hit = new Vector2(-1, 0);
    private sbyte force = 6;
    [SerializeField] int damage;
    [SerializeField] PlayerHealth health;
    [SerializeField] PlayerHealth health2;    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(hit * force, ForceMode2D.Impulse);
            health.TakeDamage(damage);
            health2.TakeDamage(damage);
        }
    }
}
