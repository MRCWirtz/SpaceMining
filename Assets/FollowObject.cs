using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform spacecraft;
    public Vector3 offset = new Vector3(0f, 0f, -1f);

    // Update is called once per frame
    void Update()
    {
        transform.position = spacecraft.position + offset;
    }
}
