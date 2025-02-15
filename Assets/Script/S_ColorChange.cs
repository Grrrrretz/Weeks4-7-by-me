using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_ColorChange : MonoBehaviour
{
    public SpriteRenderer colorchage;
    public float Timer = 0f;
    public float totaltime = 3f;
    public bool changing = false;
    // Start is called before the first frame update
    void Start()
    {
        colorchage = colorchage.GetComponent<SpriteRenderer>();//Get the target's SpriteRenderer
    }

    // Update is called once per frame
    void Update()
    {
      if (changing == true)
        {
            Timer += Time.deltaTime;
            if (Timer > totaltime)
            {
                colorchage.color = Random.ColorHSV();
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
