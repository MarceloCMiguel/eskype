using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarCounter : MonoBehaviour
{
    public Text textComp;
    GameManager gm;
    // Start is called before the first frame update

    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        textComp.text = $"x {gm.stars}";
        if ((gm.stars > 4) && (gm.level == 1))
        {
<<<<<<< HEAD
            SceneManager.LoadScene("Level2");
=======
>>>>>>> b2a3439c5205b14b5ee6c64a68f6639a0ea080cc
            gm.level = 2;
            gm.stars = 0;
            SceneManager.LoadScene("Level2");            
        }
        if((gm.stars > 2) && (gm.level == 2))
        {
            gm.stars = 0;
<<<<<<< HEAD
            gm.level = 1;
=======
            SceneManager.LoadScene("FinalScreen");
>>>>>>> b2a3439c5205b14b5ee6c64a68f6639a0ea080cc
        }
    }
}
