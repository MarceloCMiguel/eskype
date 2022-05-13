using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
   private float speed = 150f;
    GameManager gm;
    public AudioClip saw;
    public Renderer rend;

    private bool get;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        // rend = GetComponent<Renderer>();
        // audio = GetComponent<AudioSource>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
        get = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Time.deltaTime * speed, 0.0f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(get == false){
        get = true;
        GetComponent<AudioSource>().Play();
        // rend.enabled = false;
        gm.stars ++;
        Destroy(gameObject, GetComponent<AudioSource>().clip.length);
        
        }
        
    }
}
