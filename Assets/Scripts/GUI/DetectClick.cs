
using UnityEngine;
using System.Collections;
using _unity;

public class DetectClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick(){
		_.l ("Click Detected :" + gameObject.name);
		        
		if ((gameObject.name.Length > 4) && (gameObject.name.Substring (0,5)=="level")) {
			int str = int.Parse(gameObject.name.Substring(5));
			GameManager.Instance.ChangeLevel (str);
        }

		
		//Application.LoadLevel ();
		}

}
