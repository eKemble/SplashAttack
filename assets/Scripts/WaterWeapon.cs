using UnityEngine;
using System.Collections;

public class WaterWeapon : MonoBehaviour {
    ParticleSystem ps;
    public float currentWaterSupply=150;

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
           if(currentWaterSupply >= 0)
            {
                ps.Play();
                currentWaterSupply -= 10;                       
            }
        }

    }

    //refill tanks
    void OnTriggerEnter(Collider other)
    {       
        if(other.gameObject.tag== "refill")
        currentWaterSupply= 150;
    }
 
}
