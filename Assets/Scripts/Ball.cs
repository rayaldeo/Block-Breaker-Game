using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private bool hasStarted=false;
	private Vector3 paddleToBallVector;
	
	
	// Use this for initialization
	void Start () {
		//This is how we programatically find an object when creating a new leve
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector=this.transform.position - paddle.transform.position;
		//print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
			//Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position+paddleToBallVector;
		//Waiting for a Mouse Press for a Launch
		if(Input.GetMouseButtonDown(0)){
			//print ("Mouse Clicked");
			hasStarted=true;
			this.rigidbody2D.velocity = new Vector2(3f,10f);
		}
		}
	}
}
