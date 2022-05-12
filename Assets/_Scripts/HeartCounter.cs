using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartCounter : MonoBehaviour
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
        textComp.text = $"{gm.lifes} x";
    }
}
