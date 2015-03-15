using UnityEngine;
using System.Collections;

public class levelMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
         for(int i=0;i<5;i++)
         {
             if (GUI.Button(new Rect(10,10+70*i,100,60),"Level " + (i + 1)))
             {
                 Application.LoadLevel("Level"+(i+1));
             }
         }
    }
}
