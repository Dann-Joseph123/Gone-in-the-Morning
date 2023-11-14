using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothfactor;



    private void FixedUpdate()
    {
        //transform.position = target.position+offset;
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPosition,smoothfactor*Time.fixedDeltaTime);
        transform.position = smoothPos;
    }
}
