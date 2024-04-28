using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TylleplasterManager : MonoBehaviour, ITriggerable
{
    public GameObject arrow;

    public void TriggerEvent(GameObject gameObject)
    {
        if (gameObject.name == "Trylleplaster")
        {
            arrow.SetActive(true);
        }
    }
}
