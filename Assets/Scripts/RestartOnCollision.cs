using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnPlayerTrigger : MonoBehaviour
{
    public string playerTag = "Player"; // Çarpan objeye atayacaðýnýz tag

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

