using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Collider2D attackCollider;

    public int attackDamage = 10;
    public Vector2 knockback = Vector2.zero;

    private void Awake()
    {
        attackCollider = GetComponent<Collider2D>();
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //can it hit?
        Damageable damageable = collision.GetComponent<Damageable>();

        if (damageable != null)
        {
            //hit the target
            bool gotHit = damageable.Hit(attackDamage, knockback);

            if (gotHit)
            {
                Debug.Log(collision.name + " hit for " + attackDamage);
            }
            
        }
    }
}
