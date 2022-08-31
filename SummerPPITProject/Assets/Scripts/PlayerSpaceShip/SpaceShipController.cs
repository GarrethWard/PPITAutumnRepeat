using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    SoundManager sm;

    [SerializeField] private AudioClip laserSound;

    Cannon[] cannons;

    public double fireRate = 0.3;
    public double nextFire = 0.0;

    void Start()
    {
        cannons = transform.GetComponentsInChildren<Cannon>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            foreach (Cannon cannon in cannons)
            {
                nextFire = Time.time + fireRate;
                cannon.Shoot();

                SoundManager.instance.PlayLaserSound();
            }
        }
    }
}
