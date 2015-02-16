using UnityEngine;
using System.Collections;

public class BallFactory : MonoBehaviour 
{
	public POSITION position;
	public GameObject plus, minus;

	// Use this for initialization
	void Start () 
	{
		SetPosition ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void ShotBall()
	{
		float random = Random.Range (1, 3);
	}

	void SetPosition()
	{
		switch (position) 
		{
			case POSITION.LEFT:
				transform.position = Camera.main.ViewportToWorldPoint(new Vector2(0.8f,0.8f));
				break;
			case POSITION.RIGHT:
				transform.position = Camera.main.ViewportToWorldPoint(new Vector2(0.2f,0.8f));
				break;
		}
	}

	public enum POSITION
	{
		LEFT,
		RIGHT,
	}
}
