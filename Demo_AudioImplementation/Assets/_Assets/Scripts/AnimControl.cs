using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    private Animator animator;
   
    // Update is called once per frame
    void OnTriggerEnter(Collider Col)
    {
        animator = GetComponent<Animator>();
       
        //resume
        if (animator.speed == 0f)
        {
            animator.speed = 1f;
        }
        //Pause
        else
        {
            animator.speed = 0f;
        }

    }
}

