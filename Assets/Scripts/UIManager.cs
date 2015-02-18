using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
	public UILabel[] labels;
	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < labels.Length-1; i++) 
		{
			labels [i].enabled = false;
		}

		Invoke ("SetActiveLabel", 2);
	}

	void Update () 
	{
		if (GameDataManager.GetInstance ().Time < 0) 
		{
			SetGameOverLabel();
		}
	}

	void SetActiveLabel()
	{
		for (int i = 0; i < 2; i++) 
		{
			if(labels[i].enabled)
			{
				labels[i].enabled = false;
			}
			else
			{
				labels[i].enabled = true;
			}
		}
        labels[labels.Length-1].enabled = false;
		GameDataManager.GetInstance ().IsPlaying = true;
	}

	void SetGameOverLabel()
	{
		if (!labels [2].enabled) 
		{
			for (int i = 2; i < labels.Length-1; i++) 
			{
				labels [i].enabled = true;
			}
		} 
		else 
		{
			if(Input.GetMouseButtonDown(0)){
				Application.LoadLevel("title");
			}
		}
	}
}
