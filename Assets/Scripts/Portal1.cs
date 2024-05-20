using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1 : MonoBehaviour
{

    public Scene _scene;
    public AudioSource audioSource; // Ses efekti kayna��
    private void Awake()
    {
        // aktif sahneyi getir
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter(Collider other)
    {
        //�arpacak objenin tag� Player olsun!!!
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            SceneManager.LoadScene(_scene.buildIndex + 1);
        }
    }
}

