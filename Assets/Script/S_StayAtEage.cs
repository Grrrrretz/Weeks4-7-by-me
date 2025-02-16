using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_StayAtEdge : MonoBehaviour
{
    public Transform uimove;
    public float test;
    public float test1;

    public float number = 3/4;

    public float contrlX;
    public float contrlY;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bottomL = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));//Get the world coordinates in the bottom left corner of the screen
        Vector3 bottomR = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));//Get the world coordinates in the bottom right corner of the screen
        Vector3 topL = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));//Get the world coordinates in the top left corner of the screen
        Vector3 topR = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));//Get the world coordinates in the left right corner of the screen

      float number1 = bottomR.x * 0.08f;

    uimove.position = new Vector3(bottomR.x- bottomR.x* 5/3+ number1, 0, 0);//Dynamic values are used to control the real-time position of Canva on the screen, and I used this method because I wasn't sure if I could put another canvas inside the canvas
        test = bottomR.x - bottomR.x * 5/3;
        test1 = bottomR.x;
    }
}