using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableAnim : MonoBehaviour
{
    public Animator anim;
    public Collider2D collid;


    public void SelfDestruct()
    {
        Destroy(gameObject);
    }

    public void TriggerCollected()
    {
        anim.SetTrigger("Collected");
        collid.enabled = false;
    }
}
