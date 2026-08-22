using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private InputActionReference loncat;
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

    void OnEnable()
    {
        loncat.action.Enable();
        loncat.action.performed += OnJump;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnDisable()
    {
        loncat.action.performed -= OnJump;
        loncat.action.Disable();
    }

    private void OnJump(InputAction.CallbackContext callbackContext)
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, velocity);
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
