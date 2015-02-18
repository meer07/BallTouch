using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour 
{
	private const int minite = 60;
	private int countFrame;

	// Use this for initialization
	void Start () 
	{
		GameDataManager.GetInstance ().Time = 60;
		countFrame = minite;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameDataManager.GetInstance().IsPlaying)
		CountTime ();
	}

	void CountTime()
	{
		if (countFrame < 0) 
		{
			GameDataManager.GetInstance ().Time--;
			countFrame = minite;
		} 
		else 
		{
			countFrame--;
		}
	}	

	void GameOverJudgment()
	{
		if (GameDataManager.GetInstance ().Time < 0) 
		{
			// Game Over
			GameDataManager.GetInstance().IsPlaying = false;
		}
	}
}
