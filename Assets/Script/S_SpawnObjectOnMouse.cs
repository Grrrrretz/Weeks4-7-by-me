using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_SpawnObjectOnMouse : MonoBehaviour
{
    public GameObject stone;
    public List<GameObject> spawnedObjects;
    public Slider sliderA;

    // Start is called before the first frame update
    void Start()
    {
      spawnedObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseposition;
        if (Input.GetMouseButtonUp(0)) 
        {
            GameObject SPAWN = Instantiate(stone, transform.position, Quaternion.identity);
            spawnedObjects.Add(SPAWN);
            float  slidervalue =  sliderA.value;
            SPAWN.transform.localScale = Vector2.one * slidervalue;
        }
    }
}
