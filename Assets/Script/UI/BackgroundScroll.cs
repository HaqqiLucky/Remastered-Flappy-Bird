using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float width = 19.2f; // Sesuaikan dengan lebar 1 gambar kamu

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Menggeser posisi objek ke kiri
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Jika sudah bergeser sejauh lebar gambarnya, reset posisinya kembali ke awal
        if (transform.position.x < startPosition.x - width)
        {
            transform.position = startPosition;
        }
    }
}