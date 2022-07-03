using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GingerController : MonoBehaviour
{
    public float speed = 3.0f;

    public float timeInvincible = 2.0f;

    int currentHealth;
     public int score ;
    bool isInvincible;
    float invincibleTimer;
    public bool isGround;
    public float jumpForce;

    Rigidbody2D rigidbody2d;
    Animator animator;


    
    float horizontal;
    float vertical;
    Vector2 lookDirection = new Vector2(1, 0);
    // Start is called before the first frame update


    AudioSource audioSource;
    public AudioClip clip;


    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        score = 0;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
     
        
       vertical = Input.GetAxis("Vertical");
        
        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {

            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("X", lookDirection.x);
        animator.SetFloat("Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }

        bool jumping = Input.GetKeyDown("space");
        if (Input.GetKeyDown("space") && isGround == true)
        {
            rigidbody2d.AddForce(Vector3.up * 12000);
            
        }
        animator.SetBool("Jump", jumping);



    }
    void FixedUpdate()
    {



        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.fixedDeltaTime;
        position.y = position.y + speed * vertical * Time.fixedDeltaTime;

        rigidbody2d.MovePosition(position);


    }

    public void PlaySound(AudioClip Clip)
    {
        audioSource.PlayOneShot(Clip);
    }
    public void ChangeScore(int amount)
    {

  
        score += amount;
        PlaySound(clip);
        //currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        //UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
        //Debug.Log(score);



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
        }
    }
}
