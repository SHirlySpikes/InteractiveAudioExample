using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyPenguin : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    [Range(0f, 1f)]
    public float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

        // Update is called once per frame
        void OnTriggerEnter(Collider col)
        {

            audioSource.PlayOneShot(audioClip, volume);
        }
    
}
