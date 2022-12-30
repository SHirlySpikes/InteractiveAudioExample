using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaPenguinScript : MonoBehaviour
{
    private AudioSource jojoAudio;
    public AudioClip jojoClip;

    [Range(0f,3f)]
    public float jojoPitch;
    [Range(0f,1f)]
    public float jojoVolume;

    // Start is called before the first frame update
    void Start()
    {
        jojoAudio = GetComponent<AudioSource>();


        Debug.Log("This is my Message:" + gameObject.name);
        jojoAudio.clip = jojoClip;
        jojoAudio.Play();
        jojoAudio.pitch = jojoPitch;
        jojoAudio.volume = jojoVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
