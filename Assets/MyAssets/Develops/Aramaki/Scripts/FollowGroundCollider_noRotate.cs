using UnityEngine;

public class FollowGroundCollider_noRotate : MonoBehaviour
{
    public Transform groundColliderTransform;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = groundColliderTransform.position;
        //transform.rotation = groundColliderTransform.rotation;
        //transform.localScale = groundColliderTransform.localScale;
    }
}