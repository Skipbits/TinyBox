using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.Instance.Initialize();

	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 60), "PLAY"))
        {
            Application.LoadLevel("LevelMenu");
        }
    }
}
