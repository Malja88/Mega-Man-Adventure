using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Shooter shot;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isShooting", true);
            shot.Shoot();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("isShooting", false);
    }
}
