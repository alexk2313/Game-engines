using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{
    public float playerSpeed;
    private float move;

    public float jumpSpeed;
    public bool isJumping;


    private Rigidbody2D rb;
    private Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }




        RunAnimations();


    }


    void RunAnimations()
    {
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("isJumping", isJumping);
    }

}
