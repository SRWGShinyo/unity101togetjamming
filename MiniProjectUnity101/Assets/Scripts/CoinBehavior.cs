using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public ParticleSystem particles;
    public AudioSource source;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            source.Play();
            Instantiate(particles, transform.position, Quaternion.identity); // This will instantiate our effect at the position of the coin
            Destroy(gameObject);
        }
    }
}
