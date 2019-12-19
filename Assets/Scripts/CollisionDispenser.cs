using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDispenser : MonoBehaviour
{
    public Animation anim;
    public int pH = 1;
    public AnimationClip animationClip;

    // Start is called before the first frame update
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mehmet was here");

        if (collision.gameObject.tag == "Tube")
        {
            anim = GetComponent<Animation>();
            // define animation curve
            AnimationCurve translateX = AnimationCurve.Linear(0.0f, transform.position.x, 5.0f, (transform.position.x + 4.0f));
            animationClip = new AnimationClip();
            // set animation clip to be legacy
            animationClip.legacy = true;
            animationClip.SetCurve("", typeof(Transform), "localPosition.x", translateX);
            anim.AddClip(animationClip, "test");
            anim.Play("test");
            pH = 1;

        }
        else if (collision.gameObject.tag == "Base")
        {
            anim = GetComponent<Animation>();
            // define animation curve
            AnimationCurve translateX = AnimationCurve.Linear(0.0f, transform.position.x, 1.0f, (transform.position.x + 4.0f));
            animationClip = new AnimationClip();
            // set animation clip to be legacy
            animationClip.legacy = true;
            animationClip.SetCurve("", typeof(Transform), "localPosition.x", translateX);
            anim.AddClip(animationClip, "test");
            anim.Play("test");
            pH = 2;
        }
    }
    void OnCollisionStay(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mahmut was here");
        if (collision.gameObject.tag == "Tube")
        {
            pH = 1;

        }
        else if (collision.gameObject.tag == "Base")
        {
            pH = 2;
        }
    }

}
