using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimessagedisplay : MonoBehaviour
{
    public string infoText;
    public int messagelookedat = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (messagelookedat < 2)
        {
            GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text = "";

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (messagelookedat > 2)
        { 
            GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text= infoText;
        
    }
}
    }