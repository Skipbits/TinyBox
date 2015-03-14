using UnityEngine;
using System.Collections;
using _unity;

public class star : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "ball")
        {
            iTween.RotateBy(gameObject, new Vector3(0, 0, 2), 15f);
            coll.transform.rigidbody2D.isKinematic = true;
           // Time.timeScale = 0;
            _.l("Game WIN");
        }

    }
}
