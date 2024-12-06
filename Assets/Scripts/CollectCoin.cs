using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameManager GM;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void OnTriggerEnter2D(Collider2D TheThingThatWalkedIntoMe)
    {
        if (TheThingThatWalkedIntoMe.name == "Player")
        {
            Debug.Log("Seahorse Collected");
            audioManager.PlaySFX(audioManager.seahorse_collect);
            GM.CollectSeahorse();
            Destroy(gameObject);
        }
    }
}
