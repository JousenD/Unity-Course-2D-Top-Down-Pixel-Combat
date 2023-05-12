using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   [SerializeField] private float moveSpeed = 22f;

   private void Update() {
        Moveprojectile();
   }

   private void Moveprojectile() {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
   }
}
