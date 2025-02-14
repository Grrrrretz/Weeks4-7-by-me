using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_IconScaleChange : MonoBehaviour
{
    public Slider sliderA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float slidervalue = sliderA.value;
        transform.localScale = Vector2.one * slidervalue;
    }
}
