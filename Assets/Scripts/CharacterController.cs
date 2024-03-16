
using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    [SerializeField] private float characterSpeed;
    [SerializeField] private float jumpSpeed;


    [SerializeField] private bool grounded;

    private bool isAlive = true;




    void Awake()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        spriteRenderer = transform.GetComponent<SpriteRenderer>();
        animator = transform.GetComponent<Animator>();
    }

    // private void Start()
    //{
       //  jumpSpeed = PlayerData.Instance.playerJumpSpeed;
    //}



    void FixedUpdate()
    {

        rb.velocity = new Vector2(characterSpeed * Time.deltaTime, rb.velocity.y);
    }

    void Update()
    {
        Move();
    }



    private void Move()
    {

        if (isAlive == true && Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) )
        {

            if (Input.GetKey(KeyCode.A))
            {
                characterSpeed = -50;
                spriteRenderer.flipX = true;
                animator.SetFloat("speed", Math.Abs(characterSpeed));
            }
            else if (Input.GetKey(KeyCode.D))
            {
                characterSpeed = 50;
                spriteRenderer.flipX = false;
                animator.SetFloat("speed", Math.Abs(characterSpeed));


            }


        }



        else if (isAlive == true &&grounded == true)
        {
            characterSpeed = 0;
            animator.SetFloat("speed", characterSpeed);

            rb.velocity = Vector2.zero;
        }

        if (isAlive == true && grounded == true && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Force);

            grounded = false;

        }


    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "zemin")
        {
            grounded = true;
        }

        if(other.gameObject.tag == "dead")
        {    
            isAlive = false;
            rb.velocity = Vector2.zero;
            characterSpeed = 0;
            transform.position = new Vector2(transform.position.x , transform.position.y);
          //  transform.GetComponent<Collider2D>().isTrigger = true;
            //transform.GetComponent<Rigidbody2D>().simulated = false;




            transform.position = new Vector2(transform.position.x , transform.position.y - 0.4f);

            animator.SetTrigger("dead");
        }
    }

    void OnColliderEnter2D(Collider2D other)
    {

    }





}
