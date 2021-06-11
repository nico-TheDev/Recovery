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
        horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * runSpeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
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
