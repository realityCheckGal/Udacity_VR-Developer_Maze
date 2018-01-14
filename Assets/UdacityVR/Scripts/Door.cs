using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

    public GameObject door;
    public AudioClip openedSoundFX;
    public AudioSource doorSounds;

    public Transform startMarker;
    public Transform endMarker;
    public float speed = .25f;
    private float startTime;
    private float journeyLength;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool isLocked = true;
    // Create a boolen value called "opening" that can be checked in Update()
    bool isOpening = false;

    void Update() {
        // If the door is opening and it is not fully raised
        if ( isOpening && (transform.position.y < endMarker.position.y) ) {
            // Animate the door raising up
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
            //Debug.Log("door y = " + transform.position.y + " | end y = " + endMarker.position.y);
        } else {
            //Debug.Log("door is open");
        }

    }


    public void OnDoorClicked() {

        if (isLocked) {
            doorSounds.Play();
        } else {
            // Play the unlock sound
            doorSounds.clip = openedSoundFX;
            doorSounds.Play();
            
            // Initialize open door animation
            isOpening = true;

            startTime = Time.time;
            journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        }


    }

    public void Unlock()
    {
        isLocked = false;
    }
}
