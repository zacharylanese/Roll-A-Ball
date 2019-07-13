using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void FixedUpdate()
    {
     if (Input.GetKey("escape"))
        Application.Quit();   
    }
}
