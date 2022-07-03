using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapSpawn : MonoBehaviour
{
    public GameObject trap;
    public Transform player;
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        Vector2 spawnpos1 = new Vector2(player.position.x - Random.Range(5, 15), player.position.y + Random.Range(5, 10));
        Vector2 spawnpos2 = new Vector2(player.position.x - Random.Range(5, 15), player.position.y + Random.Range(5, 10));

        Instantiate(trap, spawnpos1, transform.rotation);
        Instantiate(trap, spawnpos2, transform.rotation);


        if (level == 2)
        {

            Vector2 spawnpos3 = new Vector2(player.position.x - Random.Range(-5, -15), player.position.y + Random.Range(5, 10));
  
            Instantiate(trap, spawnpos3, transform.rotation);
           
        }




        Vector3 newcrePos = transform.position;
        newcrePos.x -= 55;
        transform.position = newcrePos;
        //Destroy(gameObject);

    }
}
