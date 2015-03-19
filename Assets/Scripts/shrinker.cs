 using UnityEngine;
using System.Collections;
using System;
using _unity;
using TouchScript.Gestures;

public class shrinker : MonoBehaviour {

	public float sizeFactor= 0.125f;
	public float massFactor= .5f;
    public float moveFactor = .05f;
    public ShrinkableType shrinkableType;

    float moveSize=0;

    void Start()
    {

    }

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

    //Grow
    private void pressedHandler(object sender, EventArgs e)
    {
        //_.l(gameObject.name + " Pressed");

        if(moveSize<0)
        {
            moveSize += moveFactor;
            GameManager.Instance.moveBarValue = -moveSize;
            _.l("moveSize = " + moveSize + ", moveBarValue: " + GameManager.Instance.moveBarValue);

            iTween.ScaleTo(gameObject, transform.localScale + transform.localScale * sizeFactor, 1f);
            rigidbody2D.mass += massFactor;
        }
    }

    //Shrink
    private void tappedHandler(object sender, EventArgs e)
    {
        //_.l(gameObject.name + " Touched");

        if(Mathf.Abs(moveSize)<1)
        {
            moveSize -= moveFactor * moveSize + 0.1f;
            GameManager.Instance.moveBarValue = -moveSize;
            _.l("moveSize = " + moveSize + ", moveBarValue: " + GameManager.Instance.moveBarValue);

            iTween.ScaleTo(gameObject, transform.localScale - transform.localScale * sizeFactor, 1f);
            rigidbody2D.mass -= massFactor;
        }
    }
}
