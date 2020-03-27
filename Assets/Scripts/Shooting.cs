using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public GameObject Bullet;
  public Rigidbody BulletRb;
  public Transform GunTransform;
    Vector3 vector;

  void Update()
  {
   if (Input.GetMouseButtonDown(0))
   {
     Instantiate(Bullet, transform.position, transform.rotation);
   }
  }
  void FixedUpdate()
  {
     BulletRb.AddForce(0,0,6000*Time.deltaTime);
  }
}
