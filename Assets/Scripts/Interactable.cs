using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Don't necessarily need to, but i'm labeling the class abstract as well as the methods. Abstract classes cannot be instantiated. 
//Its basically saying this is a template for future classes, but don't use this directly.
public abstract  class Interactable : MonoBehaviour {

	//By labeling this "abstract" all classes that inherit from this class "Interactable" will NEED to implement this method.
	//Notice: Abstract methods don't have a body (ends in a semicolon)
	public abstract void Identify();

}
