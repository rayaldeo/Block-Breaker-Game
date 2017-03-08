using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	private int timesHit;
	private LevelManager levelManger;
	public Sprite[] hitSprites;

	// Use this for initialization
	void Start () {
		levelManger = GameObject.FindObjectOfType<LevelManager>();
		timesHit=0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionExit2D(Collision2D col){
		bool isBreakable =(this.tag=="Breakable");
		if(isBreakable){
			HandleHits();
			}
		
	}
	
	void HandleHits(){
		timesHit++;
		int maxHits=hitSprites.Length+1;
		if(timesHit>=maxHits){
			Destroy(gameObject);
		}else{
			LoadSprites();
		}
	}
	
	//TODO Remore this method once we can actually Win!
	void SimulateWin(){
		levelManger.loadNextLevel();
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit-1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
