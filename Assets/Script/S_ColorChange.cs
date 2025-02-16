using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_ColorChange : MonoBehaviour
{
    public GameObject colorchage;
    public float Timer = 0f;
    public float totaltime = 3f;
    public bool changing = false;
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
            Timer += Time.deltaTime;
            if (Timer > totaltime)
            {
                colorchage1.color = Random.ColorHSV();
                Timer = 0f;

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
