using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DiamondCollect : MonoBehaviour
{
    public TMP_Text diamondCountText; // TextMesh Pro'daki metin referansý
    private int diamondCount = 0; // Elmas sayýsý
    public GameObject portal;
    public GameObject zemin;

    private int requiredDiamonds = 10; // Portalý aktif etmek için gereken elmas sayýsý

    void Start()
    {
        UpdateDiamondCountText(); // Baþlangýçta metni güncelle
        portal.SetActive(false); // Portalý baþlangýçta devre dýþý býrak

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible")) // Eþleþen tag varsa
        {
            diamondCount++; // Elmas sayýsýný artýr
            UpdateDiamondCountText(); // Metni güncelle

            if (diamondCount >= requiredDiamonds) // Eðer elmas sayýsý gereken deðere ulaþtýysa
            {
                ActivatePortal(); // Portalý aktif et
                CloseZemin(); //zemini kapat
            }
        }
    }
    void UpdateDiamondCountText()
    {
        diamondCountText.text = diamondCount.ToString(); // Metni güncelle
    }
    void ActivatePortal()
    {
        portal.SetActive(true); // Portalý aktif et
    }
    void CloseZemin()
    {
        zemin.SetActive(false); // Portalý aktif et
    }
}
