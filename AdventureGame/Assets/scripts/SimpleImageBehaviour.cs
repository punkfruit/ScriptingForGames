using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start(){
        imageObj = GetComponent<Image>();
    }

    public void UpdateWithFloatData(){
        imageObj.fillAmount = dataObj.value;
    }
}
