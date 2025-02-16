using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class S_Destory : MonoBehaviour
{
    public GameObject GO;//GameObject to be destroyed
    public SpriteRenderer Gameobject11;//Get the sprite
    bool Dead = false;//Animated triggers
    public AnimationCurve anim;
    public float t = 0f;
    public static bool destoryyes = false;//For button control,Use static to make the change amount globally recallable

    public bool test;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        test = destoryyes;
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 mouspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Get mouse position to world coordinates
            if (Gameobject11.bounds.Contains(mouspos))//Perform mouse position and sprite range collision determination
            {
                if (destoryyes == true)//When the button is activated, destroys the target GameObject after 1 second
                {

                    Destroy(GO, 1);
                    Dead = true;
                    Debug.Log("worked");
                }
            }
        }
        if (Dead == true)//Play the animation
        {
            Vector3 vector3 = transform.localScale;
            t += Time.deltaTime;
            transform.localScale = vector3 * anim.Evaluate(t);
        }
    }

    public void Dodestory()
    {
        destoryyes = true;
    }

    public void Dontdestory()
    {
        destoryyes = false;
    }
}
