using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().pitch = 1.3f;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
