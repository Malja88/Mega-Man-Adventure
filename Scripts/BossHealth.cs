using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] Animator animator;
    [SerializeField] GameObject flyingEnemyTrigger;
    [SerializeField] GameObject flyingRobotsTrigger;
    [SerializeField] GameObject HP1Trigger;
    [SerializeField] GameObject HP2Trigger;
    public void TakeDamage(float damage)
    {
        health -= damage;
        animator.SetTrigger("EnemyHit");
        if(health <= 1500)
        {
            flyingEnemyTrigger.SetActive(true);
            HP1Trigger.SetActive(true);
        }
        
        if(health <= 1000)
        {
            flyingRobotsTrigger.SetActive(true);
            HP2Trigger.SetActive(true);
        }
        
        if (health <= 0)
        {
            Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
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
