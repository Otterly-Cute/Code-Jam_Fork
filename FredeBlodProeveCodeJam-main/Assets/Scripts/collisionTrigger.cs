using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTrigger : MonoBehaviour
{
    public GameObject pil;

   
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        pil.SetActive(true);
    }
}
