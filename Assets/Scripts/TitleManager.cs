using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        TapToStart();
	}

    void TapToStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("game");
        }
    }
}
