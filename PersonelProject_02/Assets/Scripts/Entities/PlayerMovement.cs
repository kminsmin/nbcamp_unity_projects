using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerEventController playerEventController;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 moveDirection = Vector2.zero;
    // Start is called before the first frame update
    private void Awake()
    {
        playerEventController = GetComponent<PlayerEventController>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        playerEventController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection;
        transform.position += (Vector3)rb.velocity * Time.deltaTime * moveSpeed;
    }

}
