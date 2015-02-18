using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {
	public int plusScore, minusScore;

	// Update is called once per frame
	void Update () {
		BallTouch ();
	}

	void BallTouch()
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D hitCollistion = Physics2D.OverlapPoint(touchPosition);

			if(hitCollistion)
			{
				GameObject ball = hitCollistion.transform.gameObject;
				Debug.Log(ball.tag);

				switch(ball.tag){
				case "plus":
					GameDataManager.GetInstance().Score += plusScore;
					Destroy(ball);
					break;

				case "minus":
					GameDataManager.GetInstance().Score -= minusScore;
					Destroy(ball);
					break;

				default:
					break;
				}
			}
		}

	}
}
