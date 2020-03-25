using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public GameObject Bullet;
  public Rigidbody BulletRb;
  public Transform GunTransform;
  void Update()
  {
    if(Input.GetMouseButtonDown(0))
    {
      var gameObject = new GameObject("Some Name Here");
      var meshFilter = gameObject.AddComponent<MeshFilter>();
      gameObject.AddComponent<MeshRenderer>();
      meshFilter.sharedMesh = objectToCreate;
      gameObject.transform.position = transform.position;
      gameObject.transform.rotation = transform.rotation;
    }
  }
}
