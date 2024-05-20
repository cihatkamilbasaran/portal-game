using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DiamondCollect : MonoBehaviour
{
    public TMP_Text diamondCountText; // TextMesh Pro'daki metin referans�
    private int diamondCount = 0; // Elmas say�s�
    public GameObject portal;
    public GameObject zemin;

    private int requiredDiamonds = 10; // Portal� aktif etmek i�in gereken elmas say�s�

    void Start()
    {
        UpdateDiamondCountText(); // Ba�lang��ta metni g�ncelle
        portal.SetActive(false); // Portal� ba�lang��ta devre d��� b�rak

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible")) // E�le�en tag varsa
        {
            diamondCount++; // Elmas say�s�n� art�r
            UpdateDiamondCountText(); // Metni g�ncelle

            if (diamondCount >= requiredDiamonds) // E�er elmas say�s� gereken de�ere ula�t�ysa
            {
                ActivatePortal(); // Portal� aktif et
                CloseZemin(); //zemini kapat
            }
        }
    }
    void UpdateDiamondCountText()
    {
        diamondCountText.text = diamondCount.ToString(); // Metni g�ncelle
    }
    void ActivatePortal()
    {
        portal.SetActive(true); // Portal� aktif et
    }
    void CloseZemin()
    {
        zemin.SetActive(false); // Portal� aktif et
    }
}
