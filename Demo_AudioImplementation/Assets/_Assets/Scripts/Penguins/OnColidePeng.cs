using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColidePeng : MonoBehaviour
{
    public AudioClip leClip;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

   
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("This Is My Message:" + gameObject.name);
        GetComponent<AudioSource>().PlayOneShot(leClip,1f);
    }
}
