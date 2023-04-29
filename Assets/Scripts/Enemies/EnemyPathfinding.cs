using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 1f;
    private Vector2 moveDir;
    private Knockback knockback;

    private void Awake() {
        knockback = GetComponent<Knockback>();
        rb= GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if(knockback.GettingKnockedBack) { return; }
        
        rb.MovePosition(rb.position + moveDir*(moveSpeed*Time.fixedDeltaTime)); 
    }

    public void MoveTo(Vector2 targetPosition){
        moveDir = targetPosition;
    }
}
