using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [SerializeField]
    public AudioClip hitClip;
    [SerializeField]
    public int damageAmount = 1;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Object that collided with me: " + other.gameObject.name);
        //Debug.Log("enemy collision position: " + other.collider.transform.position);
        //Debug.Log("Player position: " + transform.position);
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(hitClip, transform.position);
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
            
        }


    }
}
