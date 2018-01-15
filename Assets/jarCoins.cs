using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarCoins : MonoBehaviour {

	public GameObject jarOfCoins;
	public Coin[] coinList;

    public void OnJarClicked() {

    	for (int i=0; i<coinList.Length; i++) {
    		Coin coin = coinList[i];
	     	Instantiate(coin.coinPoof, coin.transform.position, Quaternion.Euler(-90f, 0f, 0f));
	    	Destroy(coin.gameObject); 
	    	// All five happen almost instantaneously
	    	// How can I pause so the player hears 5 distinct coins?  
	    	// WaitForSeconds(2);		
    	}
    	Debug.Log("Awesome!  Just just collected 5 coins!");
       
    }
}
