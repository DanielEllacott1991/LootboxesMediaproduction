using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public int messagelookedat = 0;
    public Animator dooranim;
    public string messageFoundInfoText;

    private bool DoorOpened = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (messagelookedat > 2 && DoorOpened == false)
        {
            //open door
            dooranim.SetBool("DoorOpen", true);

            DoorOpened = true; 

            GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text = messageFoundInfoText;

            StartCoroutine(HideMessage());

        }


    }

    IEnumerator HideMessage()
    {
   

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);

        GameObject.FindGameObjectWithTag("messagefoundinfo").GetComponent<Text>().text = "";

    }


}
