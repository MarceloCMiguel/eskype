using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public int stars;
    public int level;
    public int lifes;
    // Start is called before the first frame update
    private static GameManager _instance;
    public static GameManager GetInstance()
    {
        if(_instance == null)
        {
        _instance = new GameManager();
        }

        return _instance;
    }

    private GameManager()
    {
        stars = 0;
        level = 1;
        lifes = 3;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
