using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoost : MonoBehaviour
{
    
   [Header("AmmoBoost")]
   public Rifle rifle;
   public int magToGive = 15;
   private float radius = 2.5f;

   [Header("Sounds")]
   public AudioClip AmmoBoostSound;
   public AudioSource audioSource;

   [Header("AmmoBox Animator")]
   public Animator animator;

   private void Update()
   {
        if(Vector3.Distance(transform.position, rifle.transform.position) < radius)
        {
           if(Input.GetKeyDown("f"))
           {
            animator.SetBool("Open", true);
           rifle.mag = magToGive;

            audioSource.PlayOneShot(AmmoBoostSound);

            Object.Destroy(gameObject, 1.5f);
           } 
        }
   }
}
