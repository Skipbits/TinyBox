 using UnityEngine;
using System.Collections;
using System;
using _unity;
using TouchScript.Gestures;

public class shrinker : MonoBehaviour {

	public float sizeFactor= 0.125f;
	public float massFactor= .5f;

    void OnEnable()
    {
        transform.GetOrAddComponent<TapGesture>().Tapped += tappedHandler;
        transform.GetOrAddComponent<LongPressGesture>().LongPressed += pressedHandler;
    }

    void OnDisable()
    {
        GetComponent<TapGesture>().Tapped -= tappedHandler;
        transform.GetOrAddComponent<LongPressGesture>().LongPressed -= pressedHandler;
    }

    private void pressedHandler(object sender, EventArgs e)
    {
        _.l(gameObject.name + " Pressed");

        iTween.ScaleTo(gameObject, transform.localScale + transform.localScale * sizeFactor, 1f);
		rigidbody2D.mass += massFactor;

    }

    private void tappedHandler(object sender, EventArgs e)
    {
        _.l(gameObject.name + " Touched");

        iTween.ScaleTo(gameObject, transform.localScale - transform.localScale *sizeFactor, 1f);
		rigidbody2D.mass -= massFactor;

    }
}
