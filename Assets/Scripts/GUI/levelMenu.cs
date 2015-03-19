using UnityEngine;
using System.Collections;

public class levelMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (Transform child in gameObject.transform) {
			if(child.GetComponent<UIButton>())
				child.gameObject.AddComponent<DetectClick>();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
