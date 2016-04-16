using UnityEngine;
using System.Collections;

public class WaterWeapon : MonoBehaviour {
    public float watertank=100;
    ParticleSystem ps; 


	void Start ()
    {
        ps = GetComponent<ParticleSystem>();
	}
	

	void Update ()
    {
        shoot();
	}

    void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            while (watertank >= 0)
            {
                ps.Play();
                //current water drops 20% a second, allows for holding fire down           
            }
        }

    }
}
