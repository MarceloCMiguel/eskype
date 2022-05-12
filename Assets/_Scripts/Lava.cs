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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gm.lifes < 1) {
            gm.lifes = 3;
            SceneManager.LoadScene("Menu");

            } else{
                gm.lifes --;
                SceneManager.LoadScene("Level2");
            }
        
        }
        
    }
}
