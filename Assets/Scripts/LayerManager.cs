using UnityEngine;
using System.Collections;

public class LayerManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IgnoreBallCollision ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void IgnoreBallCollision()
	{
		int[] ballLayers = {LayerMask.NameToLayer ("plus"), LayerMask.NameToLayer ("minus")};
		Physics2D.IgnoreLayerCollision(ballLayers[0], ballLayers[1]);
	}
}
