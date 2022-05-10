using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int stars;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
