using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] float shotTimer;
    [SerializeField] string towerType;
    
    private GameObject currentTarget;
    private bool readyToShoot = true;
    private float timeToNextShot;
    

    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Debug.Log("Enemy entered area");
            
            if (readyToShoot)
            {
                Shoot(other.gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Debug.Log("Enemy in area");

            if (readyToShoot)
            {
                Shoot(other.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log(other.gameObject.tag + " has left the area");
        
    }

    private void Update()
    {
        if (currentTarget != null) 
        {
            
        }
        if (!readyToShoot)
        {
            timeToNextShot -= Time.deltaTime;
            if (timeToNextShot < 0)
            {
                readyToShoot = true;
            }
        }
    }

    private void Shoot(GameObject target)
    {
        currentTarget = target;
        GameObject bullet = Instantiate(projectile, transform.position, projectile.transform.rotation);
        if (towerType == "Large")
        {
            bullet.transform.localScale = new Vector3(1.75f, 1.75f, 1.75f);
        }
        bullet.GetComponent<Projectile>().SetHitTarget(currentTarget);
        timeToNextShot = shotTimer;
        readyToShoot = false;
    }


}
