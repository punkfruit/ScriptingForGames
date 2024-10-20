using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEvent.Invoke();
        Debug.Log("Player interacted with object");
    }
}
