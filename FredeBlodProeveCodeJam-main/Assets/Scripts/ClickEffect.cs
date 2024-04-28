using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;

    ParticleSystem.EmitParams emitSettings;

    void Start()
    {
        emitSettings = new ParticleSystem.EmitParams();
    }

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            emitSettings.position = pos;
            particle.Emit(emitSettings, 1);
       } 
    }
}
