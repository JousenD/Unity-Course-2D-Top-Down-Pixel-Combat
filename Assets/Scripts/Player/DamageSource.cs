using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<EnemyHealth>()){
            EnemyHealth enemyhealth = other.gameObject.GetComponent<EnemyHealth>();
            enemyhealth.TakeDamage(damageAmount);
        }
    }
}
