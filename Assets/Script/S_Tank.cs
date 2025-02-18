using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_Tank : MonoBehaviour
{
    public float Speed = 3f;
    public Transform tank;
    public GameObject bullet;
    public Transform shoot;
    public AudioSource Sounds;
    public AudioClip SoundSho;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;


        tank.transform.position = new Vector3(tank.transform.position.x + move, 0, 0);



        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet1 = Instantiate(bullet, shoot.position, shoot.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = shoot.right * 10f;
            Sounds.PlayOneShot(SoundSho);
        }

        }
}
