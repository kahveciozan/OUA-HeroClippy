
using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static bool isFirstDie = false;
    public static event Action CutSceneStart;


    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    private Animator animator;
    [SerializeField] private float characterSpeed;
    [SerializeField] private float jumpSpeed;


    [SerializeField] private bool grounded;

    private bool isAlive = true;

    public AudioManager audioManager;

    //[SerializeField] Transform particlePoint;
    //[SerializeField] GameObject runParticle;








    void Awake()
    {
        CutSceneStart = null;

        rb = transform.GetComponent<Rigidbody2D>();
        spriteRenderer = transform.GetComponent<SpriteRenderer>();
        animator = transform.GetComponent<Animator>();
    }


    void Start()
    {
        audioManager.bgMusic.Play();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(characterSpeed * Time.deltaTime, rb.velocity.y);
    }

    void Update()
    {
        Move(PlayerData.Instance);

        spriteRenderer.color = PlayerData.Instance.playerColor;
        transform.localScale = PlayerData.Instance.playerScale;
    }



    private void Move(PlayerData playerData)
    {

        if (isAlive == true && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {

            /*if (PlayerData.Instance.isWrongSide == true)
            {
                characterSpeed = playerData.playerSpeed * -1;
                spriteRenderer.flipX = true;
                animator.SetFloat("speed", Math.Abs(characterSpeed));
            }*/


            if (Input.GetKey(KeyCode.A))
            {
                if (playerData.A == KeyCode.A)
                {
                    characterSpeed = playerData.playerSpeed * -1;
                    spriteRenderer.flipX = true;
                    animator.SetFloat("speed", Math.Abs(characterSpeed));

                    //  GameObject particle = Instantiate(runParticle, particlePoint.position, Quaternion.identity, null);
                    // Destroy(particle, 0.2f);
                }

                else
                {
                    characterSpeed = playerData.playerSpeed;

                    spriteRenderer.flipX = false;
                    animator.SetFloat("speed", Math.Abs(characterSpeed));
                }

            }

            else if (Input.GetKey(KeyCode.D))
            {
                if (playerData.D == KeyCode.A)
                {
                    characterSpeed = playerData.playerSpeed * -1;
                    spriteRenderer.flipX = true;
                    animator.SetFloat("speed", Math.Abs(characterSpeed));
                }

                else
                {
                    characterSpeed = playerData.playerSpeed;
                    spriteRenderer.flipX = false;
                    animator.SetFloat("speed", Math.Abs(characterSpeed));
                }
            }

        }



        else if (isAlive == true && grounded == true)
        {
            characterSpeed = 0;
            animator.SetFloat("speed", characterSpeed);
        }

        if (isAlive == true && grounded == true && Input.GetKey(KeyCode.W) && PlayerData.Instance.isJumpable == true)
        {

            if (playerData.W == KeyCode.W)
            {

                grounded = false;
                PlayerData.Instance.isJumpable = false;
                rb.AddForce(transform.up * PlayerData.Instance.playerJumpSpeed, ForceMode2D.Force);

                audioManager.jump.Play();
            }

            else
            {
                characterSpeed = playerData.playerSpeed * -1;
                spriteRenderer.flipX = true;
                animator.SetFloat("speed", Math.Abs(characterSpeed));

            }
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
            transform.GetComponent<Collider2D>().isTrigger = true;
            rb.AddForce(transform.up * PlayerData.Instance.playerJumpSpeed, ForceMode2D.Force);
            characterSpeed = 0;


            audioManager.bgMusic.Stop();
            audioManager.death.Play();


            if (isFirstDie)
            {
                StartCoroutine(GameManager.instance.Death());
                Debug.Log("1");
            }
            else
            {
                Debug.Log("2");

                isFirstDie = true;

                CutSceneStart?.Invoke();

            }
        }


        if (other.gameObject.tag == "fallDeath")
        {
            isAlive = false;
            animator.SetTrigger("dead");
            transform.GetComponent<Collider2D>().isTrigger = true;
            //rb.AddForce(transform.up * PlayerData.Instance.playerJumpSpeed, ForceMode2D.Force);
            characterSpeed = 0;

            audioManager.bgMusic.Stop();
            audioManager.fallDeath.Play();



            StartCoroutine(GameManager.instance.Death());

        }

        if (other.gameObject.tag == "Collectable")
        {
            //  GameManager.instance.collectableCount += 1;

        }
    }











}
