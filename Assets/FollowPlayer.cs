using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public Transform PlayerTransform;
  public Vector3 offset;
  void FixedUpdate()
  {
    transform.position = PlayerTransform.position + offset;
  }
}

