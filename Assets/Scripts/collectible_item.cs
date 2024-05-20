using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    public AudioClip collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Karakter objemize çarptýðýnda
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }
}
