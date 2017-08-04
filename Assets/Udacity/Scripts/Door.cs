using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
	public bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool opening;
	public AudioSource doorSounds;
	public AudioClip doorLocked;
	public AudioClip doorOpening;

	void Start() {
		locked = true;
		opening = false;
	}

	void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if (opening && transform.position.y < 8f) {
			transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
		}
    }

    public void OnDoorClicked() {
		doorSounds = GetComponent<AudioSource>();
        // If the door is clicked and unlocked
		if (locked == false) {
			// Set the "opening" boolean to true
			opening = true;
			doorSounds.PlayOneShot (doorOpening);
		} else {
			// (optionally) Else
			// Play a sound to indicate the door is locked
			doorSounds.PlayOneShot (doorLocked);
		}
        
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
