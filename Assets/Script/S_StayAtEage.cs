using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StayAtEdge : MonoBehaviour
{
    public Transform uimove;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bottomL = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));//Get the world coordinates in the bottom left corner of the screen


        uimove.position = new Vector3(bottomL.x + 3.5f, 0, 0);
    }
}