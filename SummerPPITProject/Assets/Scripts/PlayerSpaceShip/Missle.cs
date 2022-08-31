using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
   
    public Vector2 direction = new Vector2(0, 1);
    public float speed = 5;
    public Vector2 velocity;

    public void Start()
    {      
        Destroy(gameObject, 5);   
    }

    public void FixedUpdate()
    {
        velocity = direction * speed;
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
       
    }
}
