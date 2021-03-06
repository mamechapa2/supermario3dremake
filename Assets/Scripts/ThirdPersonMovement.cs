using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform camera;

    public float speed = 6;
    public float jumpHeight = 3;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    public Vector3 velocity;
    public float gravity = -9.8f;
    bool isGrounded;

    private Animator animator;

    public AudioSource jumpAudio;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {   
            velocity.y = -2;
        }

        if (!isGrounded)
        {
            animator.SetFloat("Speed", 1);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            print("jump");
            jumpAudio.Play();
            animator.SetFloat("Speed", 1);
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            
            animator.SetFloat("Speed", 0.5f);

            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        
    }
}
