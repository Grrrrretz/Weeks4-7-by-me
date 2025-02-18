using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_buletMoving : MonoBehaviour
{
    float speed = 1f;
    float goingdown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y - goingdown * Time.deltaTime, 0);
    }
}
