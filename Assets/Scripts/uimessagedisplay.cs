using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimessagedisplay : MonoBehaviour
{
    public string infoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text= infoText;
        
    }
}
