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
    private Animator _animation;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _animation = GetComponent<Animator> ();
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
            rb.gravityScale = 10;
        }

        if (moveVector.x < 0)
        {
            transform.localScale = new Vector3(-0.5f, transform.localScale.y, transform.localScale.z);

        }
        else if (moveVector.x > 0)
        {
            transform.localScale = new Vector3(0.5f, transform.localScale.y, transform.localScale.z);
        }
        rb.MovePosition(rb.position + moveVector * speed);
        if (moveVector.x != 0 || moveVector.y !=0) 
        {
            _animation.SetBool("walking", true);
        }
        else _animation.SetBool("walking", false);
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
        if (collision.CompareTag("Stairs"))
        {
            _ladder = false;
        }
    }



}
