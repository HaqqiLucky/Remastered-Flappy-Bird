using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocityY * rotationSpeed);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("amanMajuSkor"))
        {
            Score.instance.UpdateScore();
        } else
        {
            SceneControl.instance.GameOver();
        }
    }
}
