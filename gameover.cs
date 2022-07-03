using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    public Text currentscore;
    public Text highestscore;
    public GingerController ginger;
    public int highest;
    private int level;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        level = PlayerPrefs.GetInt("level");

        if (level == 1)
        {
            if (PlayerPrefs.GetInt("leveloneHighest") == null)
            {
                PlayerPrefs.SetInt("leveloneHighest", 0);
            }

            highest = PlayerPrefs.GetInt("leveloneHighest");
        }
        if (level == 2)
        {
            if (PlayerPrefs.GetInt("leveltwoHighest") == null)
            {
                PlayerPrefs.SetInt("leveltwoHighest", 0);
            }

            highest = PlayerPrefs.GetInt("leveltwoHighest");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 1)
        {
            int score = PlayerPrefs.GetInt("leveloneScore");
            currentscore.text = "Current Score: " + score;
            if (highest < score)
            {
                highest = score;
                PlayerPrefs.SetInt("leveloneHighest", score);
            }
            highestscore.text = "level one Highest Score: " + highest;
        }
        if (level == 2)
        {
            int score = PlayerPrefs.GetInt("leveltwoScore");
            currentscore.text = "Current Score: " + score;
            if (highest < score)
            {
                highest = score;
                PlayerPrefs.SetInt("leveltwoHighest", score);
            }
            highestscore.text = "level two Highest Score: " + highest;
        }

    }

    public void Backmenu()
    {
        if(level==1)
        PlayerPrefs.DeleteKey("leveloneScore");
        if(level==2)
        PlayerPrefs.DeleteKey("leveltwoScore");
        SceneManager.LoadScene(0);
    }
}
