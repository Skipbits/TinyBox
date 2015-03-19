using UnityEngine;
using System.Collections;

public class NavBar_MoveBar : MonoBehaviour {

    UISlider moveBar;
    float moveBarValue;
	// Use this for initialization
	void Start () {
        moveBar = transform.GetComponent<UISlider>();
	}
	
	// Update is called once per frame
	void Update () {
        moveBarValue=GameManager.Instance.moveBarValue;
        if (moveBar.value != moveBarValue){
            moveBar.value = moveBarValue;
        }
            
	}
}
