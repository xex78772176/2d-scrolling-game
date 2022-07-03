using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitgame()
    {

        //Application.Quit();
        PlayerPrefs.DeleteKey("leveloneHighest");
        PlayerPrefs.DeleteKey("leveltwoHighest");
    
        Application.Quit();



    }
    public void howtoplay()
    {
        SceneManager.LoadScene(4);
    }
}
