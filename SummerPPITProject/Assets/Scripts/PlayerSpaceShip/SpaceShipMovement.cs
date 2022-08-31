using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    float verticalMovement;
    float horizontalMovement;
    public  float speed = 10;
  
    void Update() { 
    horizontalMovement = Input.GetAxisRaw("Horizontal") * speed;

        verticalMovement = Input.GetAxisRaw("Vertical") * speed;

        if (horizontalMovement > 0.01f)
{
            transform.localScale = Vector3.one;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
           
        }
       
        else if (horizontalMovement < -0.01f)
        {
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);     
        }

        if (verticalMovement > 0.01f)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y + (speed * Time.deltaTime));

        }
        else if (verticalMovement < -0.01f)
        {  
            transform.position = new Vector2(transform.position.x , transform.position.y - (speed * Time.deltaTime));
        }
    }

}
