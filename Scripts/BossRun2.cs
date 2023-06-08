using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRun2 : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    Boss boss;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float AttackRange = 2;
    Shooter shooter;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Boss>();
        shooter = animator.GetComponent<Shooter>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
        if (Vector2.Distance(player.position, rb.position) <= AttackRange)
        {
            animator.SetTrigger("Attack");
            shooter.Shoot();
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
