using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class S_Fllowthemouse : MonoBehaviour
{
    float move;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Input.mousePosition;//Get the mouse position

        pos = Camera.main.ScreenToWorldPoint(pos);//Convert mouse position to world coordinates

        transform.position = new Vector2(pos.x, pos.y);//The mouse world coordinates replace the object's XY world coordinates
    }
}
