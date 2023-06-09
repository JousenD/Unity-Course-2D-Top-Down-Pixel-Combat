using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public bool GettingKnockedBack { get; private set; }
    [SerializeField] private float knockbBackTime = 0.2f;
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetKnockedBack(Transform damageSource, float knockBackThrust) {
        GettingKnockedBack = true;
        Vector2 difference = (transform.position - damageSource.transform.position).normalized * knockBackThrust * rb.mass;
        rb.AddForce(difference, ForceMode2D.Impulse);
        StartCoroutine(KnockRoutine());
    }

    private IEnumerator KnockRoutine(){
        yield return new WaitForSeconds(knockbBackTime);
        rb.velocity = Vector2.zero;
        GettingKnockedBack = false;
    }
}
