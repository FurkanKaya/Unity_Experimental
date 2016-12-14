using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class FloatingPlayer2DController : MonoBehaviour
{
	Rigidbody2D myBody;
	private bool movingLeft;
	private bool movingRight;
	public float moveForce = 5, boostMultiplier = 2;

	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
		//bool isBoosting = CrossPlatformInputManager.GetButton("Boost");
		//myBody.AddForce(moveVec * (isBoosting ? boostMultiplier : 1));

		bool movingLeft = CrossPlatformInputManager.GetButton("MoveLeft");
		bool movingRight = CrossPlatformInputManager.GetButton("MoveRight");

		if (movingRight) {
			myBody.velocity = new Vector3 (moveForce, myBody.velocity.y, 0f);
		}
		else if (movingLeft)
			{
				myBody.velocity = new Vector3 (-moveForce, myBody.velocity.y, 0f);
			}
			else
			{
				myBody.velocity = new Vector3 (0f, myBody.velocity.y, 0f);
			}

	}
}
