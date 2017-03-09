using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float mousePosInBlocks;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y,0f);
		//this.transform.position.y->This function will keep the y variable set in the
		//inspecter for the object
		mousePosInBlocks=Mathf.Clamp(Input.mousePosition.x/Screen.width*16,1f,15f);
		//print (mousePosInBlocks);
		paddlePos.x =mousePosInBlocks;
		this.transform.position=paddlePos;
	
	}
}
