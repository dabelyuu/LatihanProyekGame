using UnityEngine;

public class Awan : MonoBehaviour
{
    public float speed = 2f;
    public float resetPositionX = -9f;  // Saat keluar dari kiri, akan di-reset
    public float startPositionX = 9f;   // Muncul kembali dari kanan

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < resetPositionX)
        {
            transform.position = new Vector2(startPositionX, transform.position.y);
        }
    }
}

