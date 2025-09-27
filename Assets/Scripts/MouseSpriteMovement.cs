using System;
using UnityEngine;

public class MouseSpriteMovement : MonoBehaviour
{
    // Adjusts the speed of the mouse, we can edit this in Unity Inspector
    [SerializeField] private float speed;

    public GameObject mc;

    // A 2D Vector we will use to manipulate movement
    private Vector3 myPosition;
    private Vector2 direction;
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myPosition = new Vector3(mc.transform.position.x, mc.transform.position.y, mc.transform.position.z);
        transform.position = myPosition;

        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        float x = direction.x;
        float y = direction.y;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("up", true);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
            anim.SetBool("left", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("down", true);
            anim.SetBool("right", false);
            anim.SetBool("left", false);
            anim.SetBool("up", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("right", true);
            anim.SetBool("down", false);
            anim.SetBool("left", false);
            anim.SetBool("up", false);
        }
    }
}
