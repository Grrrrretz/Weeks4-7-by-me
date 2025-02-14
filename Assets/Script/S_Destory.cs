using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class S_Destory : MonoBehaviour
{
    public GameObject GO;
    public SpriteRenderer Gameobject11;
    bool Dead = false;
    public AnimationCurve anim;
    public float t = 0f;
    public static bool destoryyes = false;

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
            Vector2 mouspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Gameobject11.bounds.Contains(mouspos))
            {
                if (destoryyes == true)
                {

                    Destroy(GO, 1);
                    Dead = true;
                    Debug.Log("worked");
                }
            }
        }
        if (Dead == true)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * anim.Evaluate(t);
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
