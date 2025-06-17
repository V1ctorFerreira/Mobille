using UnityEngine;

[RequireComponent (typeof(Rigidbody2D),typeof(BoxCollider2D))]
public class PLayerMove : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    Rigidbody2D rb;
    Vector2 movement;
    [SerializeField] float speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = joystick.Direction;
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = movement * speed;
    }
}
