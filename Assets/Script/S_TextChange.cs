using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_TextChange : MonoBehaviour
{

    public GameObject obj;//Get the gameobject you want to check for active
    public TextMeshProUGUI text1;//Get the text you want to change
    public string text2;//It is convenient to set different names to achieve the purpose of script reuse
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (obj.activeSelf == true)//When the target game object is active, let the text display "Active"
        {
            text1.text = "Active";
        }
        else//When the target game object is not active, it is displayed so that the text shows the "original name"
        {
            text1.text = text2;
        }
    }
}