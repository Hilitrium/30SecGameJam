using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Public Variables
    public float walkspeed;
    public float jumpForce = 2.0f;

    //private variables
    Rigidbody rb;
    Vector3 moveDirection;
    Vector3 jump;

    public bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    //void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    // Update is called once per frame

    void OnCollisionStay()
    {
        isGrounded = true;
       // Debug.Log("colliding");
    }

    void OnCollisionExit()
    {
        isGrounded = false;
       // Debug.Log("in air");
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 yVelFix = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = moveDirection * walkspeed * Time.deltaTime;
        rb.velocity += yVelFix;
    }
}
