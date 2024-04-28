using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor_room : MonoBehaviour
{
    public GameObject Appear_Button_YES;
    public GameObject Appear_Button_NO;
    public bool Starting;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StoryDelay_2());
        Starting = true;
    }

    private IEnumerator StoryDelay_2()
    {
        yield return new WaitForSeconds(28);
        Debug.Log("huhu");
        Appear_Button_YES.gameObject.SetActive(true);
        Appear_Button_NO.gameObject.SetActive(true);
    }
}
