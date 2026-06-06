using UnityEngine;

public class itempickable : MonoBehaviour
{
    // Fungsi ini terpanggil otomatis saat objek lain masuk ke area trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek apakah yang menabrak adalah Player
        if (collision.CompareTag("Player"))
        {
            // Tambahkan efek suara atau skor di sini nanti
            Debug.Log("Item collected!");

            // Hancurkan objek pisang dari scene
            Destroy(gameObject);
        }
    }
}