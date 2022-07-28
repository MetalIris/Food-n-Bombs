using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddForceObject : MonoBehaviour
{
    public Rigidbody2D rb;
    public float RandomValue;

    private void Update()
    {
        RandomValue = Random.Range(-8, 8);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Explode();           
        }       
    }
    public void Explode()
    {
        
        rb.AddForce(new Vector3(RandomValue, RandomValue, 0));
    }
}
