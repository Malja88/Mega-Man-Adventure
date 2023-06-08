using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] Animator animator;
    public void TakeDamage(float damage)
    {
        health -= damage;
        animator.SetTrigger("EnemyHit");
        if (health <= 0)
        {
            Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            animator.SetTrigger("EnemyHit");
        }  
    }

    public void Die()
    {
        animator.SetFloat("isDead", health);
        StartCoroutine(RemoveEnemy());
    }

    private IEnumerator RemoveEnemy()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }
}
