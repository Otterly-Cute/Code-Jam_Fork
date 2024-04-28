using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_needle : MonoBehaviour
{
    public Animator animator;
    SoundManager soundManager_get;
    public GameObject Appear_Button_Arrow;




    void Start()
    {
        soundManager_get = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<SoundManager>();
        animator = GetComponent<Animator>();
        StartCoroutine(Delay());
        soundManager_get.playSFX("Needle_scene");
        StartCoroutine(StoryDelay_2());
    }

    private IEnumerator StoryDelay_2()
    {
        yield return new WaitForSeconds(17);
        Appear_Button_Arrow.gameObject.SetActive(true);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        Shifter();
    }

    private void Shifter()
    {
        animator.Play("Scene_1needle");
        StartCoroutine(Delay_2());
    }

    private IEnumerator Delay_2()
    {
        yield return new WaitForSeconds(7f);
        Shifter_2();
    }

    private void Shifter_2()
    {
        animator.Play("Scene_2needle");
    }


}
