using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlowOMeter : MonoBehaviour
{
    public Slider slider;
    public AudioSource source;
    public MicrophoneSensor microphoneScript;

    public GameObject button;

    public int countUp = 0;
    public float minimumDecibel = 0.5f;

    private SoundManager soundManager;
    public void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<SoundManager>();
        soundManager.playSFX("puste");
    }

    void Update()
    {
        if (microphoneScript.GetDecibelFromMicrophone() > minimumDecibel)
        {
            slider.value = countUp++;
        }

        if (slider.value == 20 && button.activeSelf == false)
        {
            button.SetActive(true);
            soundManager.playSFX("puste2");
        }
    }
}
