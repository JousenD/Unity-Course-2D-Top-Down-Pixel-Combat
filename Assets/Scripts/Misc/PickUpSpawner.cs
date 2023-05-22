using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField] private GameObject goldCoinPickup;

    public void DropItem() {
        Instantiate(goldCoinPickup, transform.position, Quaternion.identity);
    }
    
}
