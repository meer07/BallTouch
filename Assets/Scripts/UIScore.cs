using UnityEngine;
using System.Collections;

public class UIScore : MonoBehaviour {
	public UILabel label;
	// Use this for initialization
	void Start () {
		label.text = "Score:0";
	}
	
	// Update is called once per frame
	void Update () {
		label.text = "Score:" + GameDataManager.GetInstance ().Score.ToString ();
	}
}
