using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController2D controller;
    [SerializeField] Animator animator;
    [SerializeField] private float runSpeed;
    [SerializeField] Shooter shooter;
    [SerializeField] Rigidbody2D rb;
    float horizontalMove = 0f;
    bool jump = false;
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJump", true);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            shooter.Shoot();
            animator.SetBool("isShoot", true);
        }
        if(Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("isShoot", false);
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void OnLanding()
    {
        animator.SetBool("isJump", false);
    }
}
