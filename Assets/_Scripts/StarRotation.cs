using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
   private float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Time.deltaTime * speed, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;
    }
}
