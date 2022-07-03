using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BakerController : MonoBehaviour
{
    private float speed ;
  


    Rigidbody2D rigidbody2D;

    int direction = -2;
    public Transform player;

    Animator animator;

    public GingerController ginger;
    private int level;
    

    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
        animator = GetComponent<Animator>();

        ginger =  GameObject.FindWithTag("Player").GetComponent<GingerController>();
        if(level == 1)
        {
            speed = 0.5f;

        }
        if(level == 2)
        {
            speed = 1.0f;
        }

    }

    // Update is called once per frame
    void Update()

    {
        if (level == 1)
        {
            speed += 0.001f;

        }
        if (level == 2)
        {
            speed += 0.005f;
        }
        Vector2 position = rigidbody2D.position;

     
            position.x = position.x + Time.deltaTime * speed * direction;
            position.y = player.position.y;
            animator.SetFloat("Move X", 5f);
            animator.SetFloat("Move Y", 0);

        

        rigidbody2D.MovePosition(position);
       

    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Player")
        {
            if (level == 1)
            {
                PlayerPrefs.SetInt("leveloneScore", ginger.score);

            }
            if (level == 2)
            {
                PlayerPrefs.SetInt("leveltwoScore", ginger.score);
            }
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


}