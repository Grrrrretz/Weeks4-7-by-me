using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_SpawnObjectOnMouse : MonoBehaviour
{
    public GameObject stone;//Get the prefab with want to generate
    public List<GameObject> spawnedObjects;//Create an arraylist to store the newly generated prefab
    public Slider sliderA;//Get the slider

    // Start is called before the first frame update
    void Start()
    {
      spawnedObjects = new List<GameObject>();//Declare the arraylist
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Convert mouse position to world coordinates
        transform.position = mouseposition;//Follow the mouse in real-time position
        if (Input.GetMouseButtonUp(0)) //When you left-click, a prefab is generated at the current location and added to the previously created array list
        {
            GameObject SPAWN = Instantiate(stone, transform.position, Quaternion.identity);
            spawnedObjects.Add(SPAWN);
            float  slidervalue =  sliderA.value;//Use the value of the slider to change the size
            SPAWN.transform.localScale = Vector2.one * slidervalue;
        }
    }
}
