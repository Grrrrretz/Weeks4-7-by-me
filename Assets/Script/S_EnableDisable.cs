using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public S_EnableDisable script;
    public GameObject GO;
    public AudioSource AudioS;
    public AudioClip cilp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;
            //script.enabled = false;
            GO.SetActive(false);
           // GO.activeInHierarchy;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;
            //script.enabled = true;
            GO.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(AudioS.isPlaying == false)
            {
                //AudioS.Play();
                AudioS.PlayOneShot(cilp);
            }
           
        }

    }
}
