using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float scrollSpeed = 10f;

    private void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        if (scrollInput != 0)
        {
            Vector3 newPosition = transform.position;
            newPosition += Vector3.left * scrollInput * scrollSpeed;
            transform.position = newPosition;
        }
    }
}