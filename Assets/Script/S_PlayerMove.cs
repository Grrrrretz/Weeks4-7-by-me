using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class S_PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1f;
    float movingHorizontal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveing = transform.position;

        moveing.x += Input.GetAxis("Horizontal")* Time.deltaTime*speed;
        moveing.y += Input.GetAxis("Vertical")* Time.deltaTime*speed;

        transform.position = moveing; 
    }
}
