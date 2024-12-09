using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
            transform.parent = other.transform;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        //transform.parent = null;
    }
}
