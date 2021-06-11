using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;
    public float runSpeed = 60f;
    float horizontalMove = 0f;

    bool jump = false;
    void Start()
    {

    }

    void Update()
    {
        // Enable this before final build
        // horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * runSpeed;
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (CrossPlatformInputManager.GetButtonDown("Jump") || Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }
}
