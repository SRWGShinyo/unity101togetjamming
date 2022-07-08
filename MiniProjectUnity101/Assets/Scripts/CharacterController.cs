using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rigdbody;
    public LayerMask whatisGround;
    public GameObject feet;
    public float speed;
    public float jumpForce;

    private bool isGrounded;
    private float groundDistance = 0.01f;
    private Animator anim;
    public AudioSource jump;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feet.transform.position, groundDistance, whatisGround);
        Debug.Log(isGrounded);
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0);

        if (!Mathf.Approximately(0, horizontal))
        {
            transform.rotation = horizontal < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (isGrounded && !Mathf.Approximately(0, horizontal))
        {
            anim.Play("walk");
        } else if (isGrounded)
        {
            anim.Play("idle");
        } else
        {
            anim.Play("jump");
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jump.Play();
            rigdbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        transform.position += movement * speed * Time.deltaTime;
    }
}
