using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagetrigger : MonoBehaviour
{
    public string messageFoundInfoText;

    public GameObject gamecontrollerobject;

    private gamecontroller gc;

    private bool lookedat = false;

    void Start()
    {
        gc = gamecontrollerobject.GetComponent<gamecontroller>();
    }

    private void OnTriggerEnter()
    {
        if (!lookedat)
        {

            lookedat = true;

            //tell contoller
            gc.messagelookedat += 1;

            GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text = messageFoundInfoText;


        }

        

    }

    private void OnTriggerExit()
    {
        GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text = "";

    }
}