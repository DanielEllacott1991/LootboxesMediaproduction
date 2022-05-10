using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messagetrigger : MonoBehaviour
{

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


        }

        

    }

    private void OnTriggerExit()
    {


    }
}