using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    protected bool isDragActive = false;
    protected Vector2 screenPosition;
    protected Vector3 worldPosition;
    protected GameObject draggableObject; // Track the currently draggable object
    protected Vector2 lastKnowPosition;

   protected void Update()
    {
        if (isDragActive && (Input.GetMouseButtonUp(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)))
        {
            DropObject();
            return;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            screenPosition = new Vector2(mousePos.x, mousePos.y);
        }
        else if (Input.touchCount > 0)
        {
            screenPosition = Input.GetTouch(0).position;
        }
        else
        {
            return;
        }

        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        if (isDragActive)
        {
            DragObject();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (hit.collider != null && hit.transform.gameObject.CompareTag("Draggable"))
            {
                draggableObject = hit.transform.gameObject; // Set the draggable object
                InitDrag();
                
            }
        }
    }

   protected void InitDrag()
    {
        isDragActive = true;
        lastKnowPosition = draggableObject.transform.position;
       
    }

    protected void DragObject()
    {
        draggableObject.transform.position = new Vector2(worldPosition.x, worldPosition.y);
    }

    protected void DropObject()
    {
        isDragActive = false;
        draggableObject = null; // Reset the draggable object
    }


}
