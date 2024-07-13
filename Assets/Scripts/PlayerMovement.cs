using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 0.5f;
    private Vector2 moveVector;
    private bool _ladder;
    private UnityEvent<GameObject> _actionObject;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");

        if (_ladder)
        {
            moveVector.y = Input.GetAxis("Vertical");
            rb.gravityScale = 0.0f;
        }
        else 
        {
            moveVector.y = 0;
            rb.gravityScale = 2;
        }

        rb.MovePosition(rb.position + moveVector * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs"))
        {

            _actionObject?.Invoke(collision.gameObject);
            _ladder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _ladder = false;

    }



}
