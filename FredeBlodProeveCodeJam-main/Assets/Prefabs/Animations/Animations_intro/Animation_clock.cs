using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animation_clock : MonoBehaviour
{
    //https://www.youtube.com/watch?v=kqBGg6Rme10&ab_channel=SpeedTutor

    public Animator animator;
    Test_Music_Shift  Starter;

    void Start()
    {
        animator = GetComponent<Animator>();
        Starter = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Test_Music_Shift>();
    }

    private void Update()
    {
        if (Starter.start == true)
        {
            StartCoroutine(Delay());
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(4.9f);
        Shifter();
    }

    private void Shifter()
    {
        animator.Play("Scene_1Trans");
        StartCoroutine(Delay_2());
    }

    private IEnumerator Delay_2()
    {
        yield return new WaitForSeconds(6f);
        Shifter_2();
    }

    private void Shifter_2()
    {
        animator.Play("Scene_2Trans");
        StartCoroutine(Delay_3());
    }


    private IEnumerator Delay_3()
    {
        yield return new WaitForSeconds(7.2f);
        Shifter_3();
    }

    private void Shifter_3()
    {
        animator.Play("Scene_3Trans");
    }
}
