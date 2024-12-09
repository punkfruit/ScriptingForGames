using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Sprite fireOn, fireOff;
    public SpriteRenderer spr;

    public void FireOff()
    {
        spr.sprite = fireOff;
    }

    public void FireOn()
    {
        spr.sprite = fireOn;
    }
}
