using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // The count of seahorses collected by the player
    public int SeahorseCollected = 0;

    // Reference to the UI Text element that displays the seahorse count
    public Text SeahorseOutput;

    // Update is called once per frame
    // Updates the UI text to display the current count of collected seahorses
    void Update() {
        SeahorseOutput.text = "Seahorses: " + SeahorseCollected;
    }

    // Increases the count of collected seahorses by one
   public void CollectSeahorse() {
    SeahorseCollected++;

   }

   // Decreases the count of collected seahorses by one
   public void UseSeahorse() {
    SeahorseCollected--;
   }
}
