using UnityEngine;
using System.Collections;
using System;
using _unity;
using TouchScript.Gestures;

public class antiShrinker : MonoBehaviour {

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

        iTween.ScaleTo(gameObject, transform.localScale + transform.localScale * GameManager.Instance.shrinkScale, 1f);

    }

    private void tappedHandler(object sender, EventArgs e)
    {
        _.l(gameObject.name+" Touched");

        iTween.ScaleTo(gameObject, transform.localScale - transform.localScale * GameManager.Instance.shrinkScale, 1f);

    }
}
