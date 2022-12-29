using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioControl : MonoBehaviour
{
    public AudioClip jojoSong1;
    public AudioClip jojoSong2;
    private AudioSource jojoAudio;

    // Start is called before the first frame update
    void Start()
    {
        jojoAudio = GetComponent<AudioSource>();
    }

   //call whenever coliding with it 
    void OnTriggerEnter(Collider col)
    {

        if(jojoAudio.clip == jojoSong1)
        {
            jojoAudio.clip = jojoSong2;
        }

        else
        {
            jojoAudio.clip = jojoSong1;
        }

        jojoAudio.Play();

        
    }
}
