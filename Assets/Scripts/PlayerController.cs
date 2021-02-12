using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput;
    public float xPositionLimit;
    Vector3 newPosition;
    Vector3 direction;
    public float MoveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        
    }
    public void FixedUpdate()
    {
        MovePlayer();

    }
    void MovePlayer()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

            newPosition = Camera.main.ScreenToWorldPoint(touch.position);
            newPosition.z = 0;
            direction = (newPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * MoveSpeed;
        
            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

}
