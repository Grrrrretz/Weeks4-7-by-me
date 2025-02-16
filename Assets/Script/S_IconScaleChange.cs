using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_IconScaleChange : MonoBehaviour
{
    public Slider sliderA;//Get the target slider
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float slidervalue = sliderA.value;//Converts the value of the slider into a float variable that can be calculated
        transform.localScale = Vector2.one * slidervalue;//Change the size
    }
}
