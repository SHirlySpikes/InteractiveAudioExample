using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudio : MonoBehaviour
{
    private AudioSource jojoAudioSource;
    public AudioClip jojoClip;

    // Start is called before the first frame update
    void Start()
    {
        jojoAudioSource = GetComponent<AudioSource>();
        jojoAudioSource.clip = jojoClip;
        jojoAudioSource.Play();

        
      
    }

    // Update is called once per frame
    void Update()
    {
        //jojoAudioSource.pitch = Random.Range(0.5f, 2.0f);

    }
}


//Peanut Butter Jelly Sandwitch

    //Ingridients : 
    //2 pieces of bread 
    //1 jar of jelly 
    //1 jar of peanut butter

    //What to do : 
    //1. take the piece of bread 
    //...
    //...
    //...

    


