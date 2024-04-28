using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSpeed = 0.1f;
    public Camera cam;

    private float initialSize;
    private float minSize;
    private float maxSize;

    public float zoomXValue = 3;

    void Start()
    {        
        initialSize = cam.orthographicSize;
        maxSize = initialSize;
        minSize = initialSize / zoomXValue;
    }

    void Update()
    {
        if (Input.touchCount != 2) {
            return;
        }
        
        Touch touchZero = Input.GetTouch(0);
        Touch touchOne = Input.GetTouch(1);

        // Find the position in the previous frame of each touch.
        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
        Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

        // Find the magnitude of the vector (the distance) between the touches in each frame.
        float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
        float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

        // Find the difference in the distances between each frame.
        float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

        // ... change the orthographic size based on the change in distance between the touches.
        cam.orthographicSize += deltaMagnitudeDiff * zoomSpeed;

        // Clamp the orthographic size to be between the minimum and maximum size.
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
        
    }
}