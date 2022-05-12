using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gm.lifes < 2) {
            gm.lifes = 3;
            gm.stars = 0;
            SceneManager.LoadScene("GameOver");

            } else{
                gm.lifes --;
                gm.stars = 0;
                SceneManager.LoadScene("Level2");
            }
        
        }
        
    }
}
