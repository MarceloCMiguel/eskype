using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
   private float speed = 150f;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Time.deltaTime * speed, 0.0f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        gm.stars ++;
        Destroy(gameObject);
    }
}
