using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1 : MonoBehaviour
{

    public Scene _scene;
    public AudioSource audioSource; // Ses efekti kaynaðý
    private void Awake()
    {
        // aktif sahneyi getir
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Çarpacak objenin tagý Player olsun!!!
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            SceneManager.LoadScene(_scene.buildIndex + 1);
        }
    }
}

