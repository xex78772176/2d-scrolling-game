using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
    private float movespeed = 7f;
    public Transform player;
    public Vector2 pos;
    public GingerController ginger;
    private int level;
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        player = GameObject.FindWithTag("Player").transform;
        pos = player.position;
        ginger = GameObject.FindWithTag("Player").GetComponent<GingerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;

        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), pos, movespeed * Time.deltaTime);
        transform.Rotate(0, 0, 180 * Time.deltaTime * 3);
        if(currentPos == pos)
        {
            Destroy(gameObject);
        }
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
