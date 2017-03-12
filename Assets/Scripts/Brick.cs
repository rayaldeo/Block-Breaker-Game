using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public AudioClip crack;
	public static int breakableCount=0;
	private int timesHit;
	private LevelManager levelManger;
	public Sprite[] hitSprites;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable =(this.tag=="Breakable");
		//Keep track of Breakable bricks
		if(isBreakable){
			breakableCount++;
			print("Breakable ++ "+breakableCount);
		}
		levelManger = GameObject.FindObjectOfType<LevelManager>();
		timesHit=0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionExit2D(Collision2D col){
		if(isBreakable){
			AudioSource.PlayClipAtPoint(crack,transform.position,0.5f);
			HandleHits();
			}
		
	}
	
	void HandleHits(){
		timesHit++;
		int maxHits=hitSprites.Length+1;
		if(timesHit>=maxHits){
			breakableCount--;
			print("Breakable -- "+breakableCount);
			levelManger.BricksDestroyed();
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
	
	public void setBreakableCount(int count){
		breakableCount=count;
	}
}
