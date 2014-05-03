using UnityEngine;
using System.Collections;

public class FirsoPersonController : MonoBehaviour {

	public float movementSpeed = 10.0f;
	public float mouseSensitivity = 2.0f;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		float rotLeftRight = Input.GetAxis ("Mouse X") * movementSpeed;

		transform.Rotate (0, rotLeftRight, 0);


		// movement
		float forewardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;
		CharacterController cc = GetComponent<CharacterController> ();

		Vector3 speed = new Vector3 ( sideSpeed, 0, forewardSpeed);

		speed = transform.rotation * speed;

		cc.SimpleMove ( speed );

	}
}
