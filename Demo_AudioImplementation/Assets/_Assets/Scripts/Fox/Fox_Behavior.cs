using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_Behavior : MonoBehaviour
{
    private AudioSource jojoSource;
    [Range(0f, 1f)]
    public float jojoVolume = 0.5f;
    [Range(-1f,2f)]
    public float jojoPitch = 1f;
    public AudioClip jojoClip;
    
    void Start()
    {
        jojoSource = GetComponent<AudioSource>();
        jojoSource.pitch = jojoPitch;
        jojoSource.volume = jojoVolume;
        jojoSource.clip = jojoClip;
        jojoSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}





