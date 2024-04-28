using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : Drag
{
    public string snapPointName; // Name of the specific snap point

    protected SnapManager snapManager;
    protected Transform snapPoint;
    protected bool isSnapped;
    protected bool hasTriggeredVFX;

    public GameObject VFX;

    private void Start()
    {
        // Find the SnapManager in the scene
        snapManager = FindObjectOfType<SnapManager>();

        // Find the specific snap point by name
        snapPoint = snapManager.GetSnapPointByName(snapPointName);
    }

     new protected void Update()
    {
        base.Update();
        // Check if the object is close to the specific snap point
        if (snapManager != null && snapPoint != null)
        {
            Vector3 closestSnapPoint = snapPoint.position;
            if (Vector3.Distance(transform.position, closestSnapPoint) < snapManager.SnapDistance)
            {
                // Snap the object to the specific snap point
                transform.position = closestSnapPoint;
                if(!isDragActive) 
                {
                isSnapped = true;
                }
            }
            else if (snapPointName != snapPoint.name)
            {
                transform.position = lastKnowPosition;
            }
            else
            {
                isSnapped = false;
            }
        }

        if (isSnapped && !hasTriggeredVFX)
        {
            playVFX();
            hasTriggeredVFX = true;
        }
    }

    protected void playVFX()
    {
        if (isSnapped && VFX != null)
        {
            Instantiate(VFX, transform.position, Quaternion.identity);
            Debug.Log("VFX played");
        }
    }
}
