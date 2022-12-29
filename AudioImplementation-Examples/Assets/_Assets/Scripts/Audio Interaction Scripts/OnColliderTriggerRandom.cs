using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
//[RequireComponent(typeof(Collider))]
public class OnColliderTriggerRandom : MonoBehaviour
{
    private AudioSource audioSource;
    private Collider _collider; 
    [Range(0f, 1f)]
    public float minVol, maxVol, SourceVol;
    [Range(-2f, 3f)]
    public float minPitch, maxPitch, SourcePitch;
    public AudioClip [] audioClips;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        _collider = GetComponent<Collider>();
    }
    private void Start()
    {
        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.volume = 0.1f;
        _collider.isTrigger = true;
    }
    public void SetSourceProperties(AudioClip audioData, float minVol, float maxVol, float minPitch, float maxPitch)
    {
        audioSource.loop = false;
        audioSource.clip = audioData;
        audioSource.volume = SourceVol + Random.Range(minVol, maxVol);
        audioSource.pitch = SourcePitch + Random.Range(minPitch, maxPitch);
    }
    // Used for Collision trigger integration 
    void OnTriggerEnter(Collider col)
        {
        SetSourceProperties(audioClips[Random.Range(0, audioClips.Length)], minVol, maxVol, minPitch, maxPitch);
        audioSource.Play();
        }
}
