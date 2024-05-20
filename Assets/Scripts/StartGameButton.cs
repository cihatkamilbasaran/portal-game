using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGameButton : MonoBehaviour
{
    public AudioSource audioSource;
    public Scene _scene;
    private void Awake()
    {
        // aktif sahneyi getir
        _scene = SceneManager.GetActiveScene();
    }

    public void Start()
    {
        audioSource = GameObject.Find("Music").GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
        audioSource.Stop();
    }
}
