using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_Timer : MonoBehaviour
{
    Slider silder;
    float t;
    void Start()
    {
        silder = GetComponent<Slider>();    
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        silder.value = t % silder.maxValue;
    }
}
