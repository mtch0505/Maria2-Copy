
using System.Collections;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    bool player_detection = false;

    void Update()
    {
       if(player_detection && Input.GetKeyDown(KeyCode.Space))
        {
            print("Dialog is triggered");

        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            player_detection = true;
        }
        Debug.Log("entered trigger");
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            player_detection = false;
        }
    }


}