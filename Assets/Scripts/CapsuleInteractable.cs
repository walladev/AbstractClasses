using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Here i've changed the : Monobehavior to : Interactable to signal that i'm inheriting from Interactable
//Note, Interactable inherits from Monobehavior, so it gets the properties from it as well (by ancestry)
public class CapsuleInteractable : Interactable {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//Now, this class since its a subclass of Interactable, and that has Identify() labeled as abstract, It will NOT compile unless it contains a "Identify()" method:
	//Notice the keyword "override" in here. Self explanatory
	public override void Identify() {
		print ("    This is the CAPSULE!!!");
	}
}
