using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		//Vector2 scale = max * 2;

		transform.localScale = max;
	}
}
