using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_ColorChange : MonoBehaviour
{
    public GameObject colorchage;//Get the object you want to modify
    public float Timer = 0f;//Set a timer
    public float totaltime = 3f;//The total time it takes to change color
    public bool changing = false;//Originally, I was going to add a button switch, but I don't know if static can be used for it, so it's abandoned
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer colorchage1 = colorchage.GetComponent<SpriteRenderer>();//Get the target's SpriteRenderer
        if (changing == true)
        {
            Timer += Time.deltaTime;//Time grows
            if (Timer > totaltime)//Time detection
            {
                colorchage1.color = Random.ColorHSV();//Change the random color
                Timer = 0f;//reset time

            }
        }
    }
    public void CotrlColorchangeopen()
    {
        changing = true;
    }
    public void CotrlColorchangeclose()
    {
        changing = false;
    }
}
