using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat1 : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] Transform AttackPoint;
    [SerializeField] float AttackRange = 0.5f;
    [SerializeField] LayerMask layers;
    [SerializeField] int AttackDamage;
    [SerializeField] float AttackRate = 2f;
    [SerializeField] EnemyScript enemyHurt;
    float NextAttackTime = 0;
    void Update()
    {
        if(Time.time >= NextAttackTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Attack();
                NextAttackTime = Time.time + 1 / AttackRate;
            }
        }

    }
        void Attack()
    {
        anim.SetTrigger("Attack");
        Collider2D[] enemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, layers);
        foreach(Collider2D enemy in enemies)
        {
            StartCoroutine(attackTime());
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }

    private IEnumerator attackTime()
    {
        yield return new WaitForSeconds(0.3f);
        enemyHurt.TakeDamage(AttackDamage);
    }
}
