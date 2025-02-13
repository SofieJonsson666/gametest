using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthRestore = 100;
    public Vector3 spinRotationSpeed = new Vector3(0, 180, 0);

    AudioSource healthPickupSource;

    private void Awake()
    {
        healthPickupSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damageable = collision.GetComponent<Damageable>();

        if(damageable)
        {

            if(healthPickupSource = null)
            {
                AudioSource.PlayClipAtPoint(healthPickupSource.clip, gameObject.transform.position, healthPickupSource.volume);
            }

            damageable.Heal(healthRestore);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.eulerAngles += spinRotationSpeed * Time.deltaTime;
    }
}
