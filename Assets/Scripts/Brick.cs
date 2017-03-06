using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int maxHits;
	private int timesHit;
	private LevelManager levelManger;

	// Use this for initialization
	void Start () {
		levelManger = GameObject.FindObjectOfType<LevelManager>();
		timesHit=0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionExit2D(Collision2D col){
		timesHit++;
		if(timesHit>=maxHits){
			Destroy(gameObject);
			}
		
	}
	
	//TODO Remore this method once we can actually Win!
	void SimulateWin(){
		levelManger.loadNextLevel();
	}
}
