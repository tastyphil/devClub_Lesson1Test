using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // moves our 2d vector depending on how much we hold WASD or the arrow keys
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // Rotate our box collider sideways if User goes left/right
        // Rotate our box collider upwards if User goes up.down
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,0,90));
        }

    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        // manipulates the direction of our mouse with regards to speed
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.linearVelocity = movementDirection * speed;
    }
}
