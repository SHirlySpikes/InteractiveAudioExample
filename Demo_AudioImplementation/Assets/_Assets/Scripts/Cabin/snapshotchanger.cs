using System.Collections;
using UnityEngine;
using UnityEngine.Audio;


public class snapshotchanger : MonoBehaviour
{
    public AudioMixerSnapshot snap1;
    public AudioMixerSnapshot snap2;
    public float transitionTime = 2f;

    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collided with: " + collision);
        snap1.TransitionTo(transitionTime);
    }

    public void OnTriggerExit(Collider collision)
    {
        Debug.Log("Collided with: " + collision);
        snap2.TransitionTo(transitionTime);
    }
}