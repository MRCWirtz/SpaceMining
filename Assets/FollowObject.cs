using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform follow;
    Vector3 offset = new Vector3(0f, 0f, -1f);
    float cameraSpeed = 0.01f;
    float zoomSpeed = 1.1f;

    // Update is called once per frame
    void Update()
    {   
        Vector2 followGround = follow.position;
        Vector2 cameraGround = transform.position;
        Vector3 update = Time.deltaTime * (followGround  - cameraGround) * cameraSpeed;
        transform.position = follow.position + update + offset;

        if (Input.GetAxis("Mouse ScrollWheel") > 0) {
            GetComponent<Camera>().orthographicSize /= zoomSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) {
            GetComponent<Camera>().orthographicSize *= zoomSpeed;
        }
    }
}
