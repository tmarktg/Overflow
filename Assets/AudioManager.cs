using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   [Header("Audio Clip")]

   public AudioClip background;
   public AudioClip character_movement;
   public AudioClip seahorse_collect;
   public AudioClip seahorse_sfx;
   public AudioClip enemy_hit;
   public AudioClip enemy_sfx;

   private void Start() {
    musicSource.clip = background;
    musicSource.Play();
   }

   public void PlaySFX(AudioClip clip)
   {
       SFXSource.PlayOneShot(clip);
   }

}
