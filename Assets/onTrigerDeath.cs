using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigerDeath : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
        deathOnCollision death = other.GetComponent<deathOnCollision>();

        if(death != null)
        {
            death.enemy.Dead(transform.position);
        }
   }
}
