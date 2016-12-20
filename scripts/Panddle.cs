using UnityEngine;
using System.Collections;

public class Panddle : MonoBehaviour {

	public float paddleSpeed = 1; 
	public Vector3 playerPos;

	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis ("Vertical") * paddleSpeed);
		playerPos = new Vector3 (-22, Mathf.Clamp(yPos, -12, 12 ), 0);
		gameObject.transform.position = playerPos;
	}
}
