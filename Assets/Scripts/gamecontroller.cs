using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public int messagelookedat = 0;
    public Animator dooranim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (messagelookedat > 1)
        {
            //open door
            dooranim.SetBool("DoorOpen", true);

        }


    }




}
