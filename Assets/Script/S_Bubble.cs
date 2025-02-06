using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_Bubble : MonoBehaviour
{
    public GameObject main;
    public GameObject NPC;

    public Sprite[] bubblelist;
    public Image img;
    bool change = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mainpostion = main.transform.position;
        Vector2 NPCposition = NPC.transform.position;

        float distance = Vector2.Distance(mainpostion, NPCposition);

        if(distance <= 0.5)
        {
            change = true;
        }
    

            if (bubblelist.Length == 0)
            {

            }
            else if(change == true)
            {
                img.sprite = bubblelist[Random.Range(0, 6)];
                change = false;
            }
    }
}
