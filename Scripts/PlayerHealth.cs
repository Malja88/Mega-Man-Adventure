using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth = 1000;
    public int currentHealth;
    [SerializeField] Animator anim;
    [SerializeField] HealthBarScript healthBar;
    [SerializeField] Animator transition;
    [SerializeField] GameObject trans;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetHealth(MaxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        anim.SetTrigger("isHit");
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
            Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Boss"))
        {
            anim.SetTrigger("isHit");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water") || collision.gameObject.CompareTag("Fire"))
        {
            currentHealth = 0;
            healthBar.SetHealth(currentHealth);
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("isHit");
            StartCoroutine(DeathOnTrigger());
        }
    }
    public void Die()
    {
        anim.SetFloat("isDead", currentHealth);
        StartCoroutine(DeathOnTrigger());
    }

    private IEnumerator DeathOnTrigger()
    {
        trans.SetActive(true);
        transition.SetTrigger("Start"); 
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
