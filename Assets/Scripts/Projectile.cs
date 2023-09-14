using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projSpeed = 10;
    public GameObject hitTarget;

    public GameObject GetHitTarget()
    {
        return hitTarget;
    }

    public void SetHitTarget(GameObject value)
    {
        hitTarget = value;
    }

    
    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(hitTarget.transform.position, Vector3.forward);
        transform.position = Vector2.MoveTowards(transform.position, hitTarget.transform.position, projSpeed * Time.deltaTime);
        Debug.Log(hitTarget);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
