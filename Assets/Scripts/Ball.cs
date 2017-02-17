using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	private bool hasStarted=false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector=this.transform.position - paddle.transform.position;
		print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
			//Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position+paddleToBallVector;
		//Waiting for a Mouse Press for a Launch
		if(Input.GetMouseButtonDown(0)){
			print ("Mouse Clicked");
			hasStarted=true;
			this.rigidbody2D.velocity = new Vector2(2f,10f);
		}
		}
	}
}
