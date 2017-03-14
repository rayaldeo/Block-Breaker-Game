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
		paddleToBallVector=this.transform.position - paddle.transform.position;//This is needed to calculate the proper space between ball and paddle
		//print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
			//Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position+paddleToBallVector;//The variable paddleToBallVector is added into the paddle position to act as
																					//ball is resting on the paddle
		//Waiting for a Mouse Press for a Launch
		if(Input.GetMouseButtonDown(0)){
			//print ("Mouse Clicked");
			hasStarted=true;
			this.rigidbody2D.velocity = new Vector2(3f,10f);
		}
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		//This line of code is used to stop the boring vertical/horizontal loop from happening
		Vector2 tweak = new Vector2(Random.Range(0.1f,0.2f),Random.Range (0f,0.2f));
		//Vector3 tweakDirection = new Vector3(Random.Range(0f,0.2f),0f,0f);
		if(hasStarted){
			audio.Play ();
			rigidbody2D.velocity+=tweak;
		}
	}
}
