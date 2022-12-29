using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicControl1 : MonoBehaviour
{

    public AudioClip songOne;
    public AudioClip songTwo;
    private AudioSource leAudio;
    
    


    void Start()
    {

        leAudio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider col)
    {
        
        if(leAudio.clip == songOne)
        {
            leAudio.clip = songTwo;
        }
        else
        {
            leAudio.clip = songOne;
        }
        
        leAudio.volume = 0.7f;
        leAudio.Play();
    }
}
