using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip collectedClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        GingerController controller = other.GetComponent<GingerController>();

        if (controller != null)
        {
            
            controller.ChangeScore(1);
             Destroy(gameObject);
            // controller.PlaySound(collectedClip);
            
        }

    }
}
