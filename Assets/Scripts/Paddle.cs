﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	private Ball ball;
	public bool autoPlayCheck=false;
	public float mousePosInBlocks;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!autoPlayCheck){
			MoveWithMous();
		}else{
			AutoPlay();
		}
	
	}
	
	
	void MoveWithMous(){
		Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y,0f);
		//this.transform.position.y->This function will keep the y variable set in the
		//inspecter for the object
		mousePosInBlocks=Mathf.Clamp(Input.mousePosition.x/Screen.width*16,1f,15f);
		//print (mousePosInBlocks);
		paddlePos.x =mousePosInBlocks;
		this.transform.position=paddlePos;
	}
	
	
	void AutoPlay(){
		Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y,0f);
		//this.transform.position.y->This function will keep the y variable set in the
		Vector3 ballPos = ball.transform.position;
		paddlePos.x =Mathf.Clamp(ballPos.x,0.5f,15.5f);
		this.transform.position=paddlePos;
		
	}
}
