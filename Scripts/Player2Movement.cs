using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField] CharacterController2D controller;
    [SerializeField] Animator animator;
    [SerializeField] private float runSpeed;
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
            animator.SetBool("isJump2", true);
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void OnLanding()
    {
        animator.SetBool("isJump2", false);
    }
}
