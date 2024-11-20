using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = musicSource.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

   public void AdjustVolume(float newVolme)
   {
        musicSource.volume = newVolme;
   }
}
