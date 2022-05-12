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
            SceneManager.LoadScene(3);
            gm.level = 2;
            gm.stars = 0;
        }
        else if ((gm.stars > 2) && (gm.level == 2))
        {
            SceneManager.LoadScene(4);
            gm.stars = 0;
        }
    }
}
