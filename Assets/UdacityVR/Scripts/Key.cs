using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

    public GameObject keyPoof;
    public Door door;


	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        Destroy(this.gameObject);

        door.Unlock();
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
