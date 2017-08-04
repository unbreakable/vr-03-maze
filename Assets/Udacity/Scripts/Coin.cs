using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject poof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        
		// Make sure the poof animates vertically
		Instantiate (poof, transform.position, Quaternion.Euler(-90,0,0));

		// Increment score
		ScoreManager.score += 1;

        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

}
