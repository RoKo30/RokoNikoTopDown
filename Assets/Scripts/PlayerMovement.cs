using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  public int brzina = 10;

  void FixedUpdate()
  {
    if(Input.GetKey("w"))
      {
      rb.velocity = new Vector3(0, 0, brzina*Time.deltaTime); 
      }
    if (Input.GetKey("a"))
    {
      rb.velocity = new Vector3(-brzina * Time.deltaTime, 0, 0);
    }
    if (Input.GetKey("s"))
    {
      rb.velocity = new Vector3(0, 0, -brzina * Time.deltaTime);
    }
    if (Input.GetKey("d"))
    {
      rb.velocity = new Vector3(brzina * Time.deltaTime, 0, 0);
    }
  }
}
