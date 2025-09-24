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
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * speed;
    }
}
