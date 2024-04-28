using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    public float SnapDistance = 0.1f; // The distance at which objects will snap

    public List<Transform> snapPoints = new List<Transform>(); // List of all snap points

    public Transform GetSnapPointByName(string snapPointName)
    {
        // Find the snap point with the specified name
        foreach (Transform snapPoint in snapPoints)
        {
            if (snapPoint.name == snapPointName)
            {
                return snapPoint;
            }
        }

        // If no snap point with the specified name is found, return null
        return null;
    }
}
