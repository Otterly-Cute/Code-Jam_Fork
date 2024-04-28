using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations_end : MonoBehaviour
{
    public Animator animator;
    SoundManager soundManager_get;
    public GameObject Appear_Button_THEEND;
    public GameObject Appear_Button_Fnaf;
    void Start()
    {
        soundManager_get = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<SoundManager>();
        animator = GetComponent<Animator>();
        StartCoroutine(Delay());
        soundManager_get.playSFX("AudioClip_end");
        StartCoroutine(StoryDelay_2());
    }

    private IEnumerator StoryDelay_2()
    {
        yield return new WaitForSeconds(14);
        Appear_Button_THEEND.gameObject.SetActive(true);
        Appear_Button_Fnaf.gameObject.SetActive(true);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.5f);
        Shifter();
    }

    private void Shifter()
    {
        animator.Play("Scene_1TransEnd");
        StartCoroutine(Delay_2());
    }

    private IEnumerator Delay_2()
    {
        yield return new WaitForSeconds(3f);
        Shifter_2();
    }

    private void Shifter_2()
    {
        animator.Play("Scene_2TransEnd");
        StartCoroutine(Delay_3());
    }

    private IEnumerator Delay_3()
    {
        yield return new WaitForSeconds(3f);
        Shifter_3();
    }

    private void Shifter_3()
    {
        animator.Play("Scene_3TransEnd");
    }

    private void fnaf()
    {
        soundManager_get.playSFX("AudioClip_end");
    }
}
