using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float speed  = 1;
    private Transform spaceShip;
    
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("MotherShip").transform;    
    }
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, spaceShip.position, speed * Time.deltaTime);
    }
}
