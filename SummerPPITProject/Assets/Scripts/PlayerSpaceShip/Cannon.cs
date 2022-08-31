using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Missle missle;
    Vector2 direction;
  
     public void Shoot()
    {
        GameObject go = Instantiate(missle.gameObject, transform.position, Quaternion.identity);
    }
}
