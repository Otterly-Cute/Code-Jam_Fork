using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlowScale : MonoBehaviour
{
    //https://www.youtube.com/watch?v=dzD0qP8viLw

   
    public Slider slider;
    public AudioSource source;
    public MicrophoneSensor microphoneScript;



    void Start()
    {
        
    }

    
    void Update()
    {
        SetSlider(microphoneScript.GetDecibelFromMicrophone());
    }

    public void SetSlider(float tmp)
    { slider.value = tmp; }

}
