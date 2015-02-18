using UnityEngine;
using System.Collections;

public enum POSITION
{
	UP,
	DOWN,
	LEFT,
	RIGHT,
}

public class Wall : MonoBehaviour 
{
	public POSITION position;

	// Use this for initialization
	void Start () 
	{
		switch (position) 
		{
			case POSITION.UP:
			SetPositon(new Vector2(0.5f, 1.05f));
			break;

			case POSITION.DOWN:
			SetPositon(new Vector2(0.5f, -0.05f));
			break;

			case POSITION.LEFT:
			SetPositon(new Vector2(-0.05f, 0.5f));
			break;

			case POSITION.RIGHT:
			SetPositon(new Vector2(1.05f, 0.5f));
			break;
		}
	}

	void SetPositon(Vector2 target)
	{
		Vector2 pos = Camera.main.ViewportToWorldPoint (target);
		gameObject.transform.position = pos;
	}
}
