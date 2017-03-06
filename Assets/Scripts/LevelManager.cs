using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
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
}
