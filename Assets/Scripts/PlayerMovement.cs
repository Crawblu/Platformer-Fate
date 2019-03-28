using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    float HorizontalMove = 0f;
    bool jump = false;

	// Update is called once per frame
	void Update () {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("isJumping", false);
    }
    private void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public float getMovement()
    {
        return HorizontalMove;
    }

    public void setMovement(float movement)
    {
        HorizontalMove = movement;
    }
}
