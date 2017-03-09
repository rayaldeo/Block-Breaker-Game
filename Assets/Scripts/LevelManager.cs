using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	private Brick brick;
	
	public void LoadLevel(string name){
		brick = new Brick();
		brick.setBreakableCount(0);
		Debug.Log("Level Load Request for: "+name);
		Application.LoadLevel(name);
	}
	
	public void QuitLevel(){
		Debug.Log("Quit Game Request");
		Application.Quit();
	}
	
	public void loadNextLevel(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
	
	public void BricksDestroyed(){
  		if(Brick.breakableCount<=0/*If last break destroyed*/){
  			loadNextLevel();
  		}
	}
}
