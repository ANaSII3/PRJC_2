using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class HealthDamager : MonoBehaviour
{
    public float damage = 20;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        
        HandleTakeDamage(collisionObject);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        
        HandleTakeDamage(collisionObject);
        
    }

    private void HandleTakeDamage(GameObject collisionObject)
    {
        if(!collisionObject.gameObject.CompareTag("Player"))
        {
            return;
        }

        PlayerStats stats = collisionObject.gameObject.GetComponent<PlayerStats>();

        if (stats == null)
        {
            return;
        }

        stats.TakeDamage(damage);

    }
}
