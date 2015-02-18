using UnityEngine;
using System.Collections;

public class GameDataManager : MonoBehaviour {
	private static GameDataManager instance = new GameDataManager ();

	private GameDataManager(){
		IsPlaying = false;
	}

	public static GameDataManager GetInstance()
	{
		return instance;
	}

	public int Score{ get; set; }
	public int Time{ get; set; }
	public bool IsPlaying{ get; set;}

	void OnDestroy()
	{
		Score = 0;
		Time = 0;
		IsPlaying = false;
	}
}
