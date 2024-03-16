
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




    void FixedUpdate()
    {

        rb.velocity = new Vector2(characterSpeed * Time.deltaTime, rb.velocity.y);
    }

    void Update()
    {
        Move(PlayerData.Instance);



    }



    private void Move(PlayerData playerData)
    {

        if (isAlive == true && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {

            if (Input.GetKey(KeyCode.A))
            {
                characterSpeed = playerData.playerSpeed * -1;
                spriteRenderer.flipX = true;
                animator.SetFloat("speed", Math.Abs(characterSpeed));
            }
            else if (Input.GetKey(KeyCode.D))
            {
                characterSpeed = playerData.playerSpeed;
                spriteRenderer.flipX = false;
                animator.SetFloat("speed", Math.Abs(characterSpeed));


            }


        }



        else if (isAlive == true && grounded == true)
        {
            characterSpeed = 0;
            animator.SetFloat("speed", characterSpeed);
            rb.velocity = Vector2.zero;
        }

        if (isAlive == true && grounded == true && Input.GetKey(KeyCode.W) && PlayerData.Instance.isJumpable == true)
        {

            grounded = false;
            PlayerData.Instance.isJumpable = false;


            rb.AddForce(transform.up * PlayerData.Instance.playerJumpSpeed, ForceMode2D.Force);



        }


    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "zemin")
        {
            grounded = true;

        }

        if (other.gameObject.tag == "dead")
        {
            isAlive = false;
            animator.SetTrigger("dead");
            rb.simulated = false;
            transform.GetComponent<Collider2D>().isTrigger = true;
            rb.AddForce(new Vector2(transform.position.x,transform.position.y - 10f) , ForceMode2D.Force);

            //transform.GetComponent<Collider2D>().transform.localEulerAngles = new Vector3(0, 0, -90);
            characterSpeed = 0;

        }
    }











}
