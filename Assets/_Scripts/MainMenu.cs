using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameManager.GetInstance();    
    }
    // Start is called before the first frame update
    public void PlayGame()
    {
<<<<<<< HEAD
=======
        gm.stars = 0;
        gm.lifes = 3;
        gm.level = 1;
>>>>>>> b2a3439c5205b14b5ee6c64a68f6639a0ea080cc
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        gm.stars = 0;
        gm.lifes = 3;
        gm.level = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Quit(){
        Application.Quit();

    }
}
