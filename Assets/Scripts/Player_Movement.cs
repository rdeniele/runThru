using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

  
    [SerializeField] public float jumpForce = 5f;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D rb;
    private Animator anim;
   
    [SerializeField] private LayerMask JumpableGround;

    //audio
    [SerializeField] private AudioSource jumpSoundEffect;

  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

  
    void Update()
    {
        //endless horizontal movement
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
        {
            jumpSoundEffect.Play();
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
            anim.SetBool("jump", true);
            anim.SetBool("run", false);

        }

      

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") && isGrounded==false)
        {
            isGrounded = true;
            anim.SetBool("jump", false);
            anim.SetBool("run", true);
        }
    }
}
