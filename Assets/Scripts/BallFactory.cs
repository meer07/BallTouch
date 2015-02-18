using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallFactory : MonoBehaviour 
{
	public POSITION position;
	public GameObject plus, minus;
	public int speed;
	private const int twoMinite = 120;
	private int countFrame;

	// Use this for initialization
	void Start () 
	{
		SetPosition ();

		for (int i = 0; i < 8; i++) 
		{
			for(int j = 0; j < 2; j++){
				Vector2 initPosition = new Vector2 (Random.Range (0.1f, 1.0f), Random.Range (0.1f, 1.0f));
				MakeBall(initPosition, j);
			}
		}

		countFrame = twoMinite;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (countFrame < 0 && GameDataManager.GetInstance().IsPlaying) {
			ShotBall (transform.position);
			countFrame = twoMinite;
		} 
		else 
		{
			countFrame--;
		}
	}
		
	void ShotBall(Vector2 position)
	{
		int selectBall = Random.Range (0, 2);
		MakeBall (position, selectBall);

	}

	void MakeBall(Vector2 position, int selectBall)
	{
		GameObject ball;

		switch (selectBall) 
		{
		case 0:
			ball = Instantiate(plus, position, Quaternion.identity) as GameObject;
			ball.rigidbody2D.velocity = new Vector2 (speed * Random.Range (-1.0f, 1.0f), speed * Random.Range (-1.0f, 1.0f));
			break;
		case 1:
			ball = Instantiate(minus, position, Quaternion.identity) as GameObject;
			ball.rigidbody2D.velocity = new Vector2 (speed * Random.Range (-1.0f, 1.0f), speed * Random.Range (-1.0f, 1.0f));
			break;
		}
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
