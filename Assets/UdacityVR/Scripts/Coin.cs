using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    public void OnCoinClicked() {

    	Instantiate(coinPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));
    	Destroy(this.gameObject);

    

        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }



}
