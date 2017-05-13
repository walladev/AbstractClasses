using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMovementController : MonoBehaviour {

	public float movementSpeed = 1f;
	Vector3 movementDirection;
	// Use this for initialization
	void Start () {
		movementDirection = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		float verticalMovement = Input.GetAxis ("Vertical");

		movementDirection.x += horizontalMovement;
		movementDirection.z += verticalMovement;

		transform.position = Vector3.Lerp(transform.position, movementDirection, movementSpeed * Time.deltaTime);
		
	}
}
