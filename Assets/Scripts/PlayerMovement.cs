using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // private PlayerInput playerInput;
    // private Vector2 moveInput;

    private float moveX;
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right

        // float xInput = Input.GetAxisRaw("Horizontal");
        // Vector2 dir = new Vector2(xInput, 0f).normalized;
        // rb.linearVelocity = dir * speed;

        // if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        // {
        //     Debug.Log("Horizontal button pressed");
        // }

        // if (Input.anyKeyDown)
        // {
        //   Debug.Log("anyKeyDown");  
        // }

        // moveInput = playerInput.actions["Move"].ReadValue<Vector2>();
        // Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        // rb.AddRelativeForce(movement * speed * Time.deltaTime);

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveX, 0) * speed;
    }
    

}
