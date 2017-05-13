using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will be attached to our cell, and handle identifying objects as they come into its collider's view.
//Note: i've attached a transparent Collider to the blood cell, and this script to that collider
public class IdentifyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//Gets the GENERIC "Interactable" (this can be a BoxInteractable or a CapsuleInteractable)
		Interactable interactableObject = other.gameObject.GetComponent<Interactable> ();
		//Checks if it is null. This is because our object can slam into any objects in the world. The only triggers we're interested in here are the 
		//interactable types. If the other object HAS an interactable, then....
		if (interactableObject != null) {
			//Call interactable.Identify. This will defer to WHATEVER form of interactable it is.
			interactableObject.Identify ();
		}

	}

}
