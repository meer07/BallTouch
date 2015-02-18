using UnityEngine;
using System.Collections;

public class UITime : MonoBehaviour {
	public UILabel label;
	// Use this for initialization
	void Start () {
		label.text = "Time:0";
	}
	
	// Update is called once per frame
	void Update () {
		if (GameDataManager.GetInstance ().Time > 0) {
			label.text = "Time:" + GameDataManager.GetInstance ().Time.ToString ();
		} 
		else 
		{
			label.text = "Time:0";
		}
	}
}
