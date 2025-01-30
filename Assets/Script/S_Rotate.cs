using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Rotate : MonoBehaviour
{
    public float speed = 1f;
    public AudioSource AudioS;
    public GameObject Bird;
    public AudioClip cilp;
    public int count = 0;
    public bool playdoit = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = transform.eulerAngles;

        soundchecking();

        Bird.SetActive(false);

        rotate.z -= speed * Time.deltaTime;
        transform.eulerAngles = rotate;

        if(Mathf.Round(rotate.z) % 30  == 0)
        {
            count += 1;
        }
        

        for(int i = 0; i< count; i++)
        {
            AudioS.Play();
        }
       
        if (playdoit == false)
        {
            Bird.SetActive(true);
        }
        else
        {
            Bird.SetActive(false);
        }
    }
    void soundchecking()
    {
        if (AudioS.isPlaying == true)
        {
            playdoit = false;
        }
        if(AudioS.isPlaying == false)
        {
            playdoit = true;
        }
    }
}
