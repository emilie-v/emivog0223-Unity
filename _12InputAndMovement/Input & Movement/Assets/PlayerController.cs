using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    [SerializeField] bool translateMovement = false;
    [SerializeField] bool forceMovement = false;
    [SerializeField] bool velocityMovement = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (translateMovement)
        {
            Vector3 movement = new Vector3(x, y, 0) * speed * Time.fixedDeltaTime;
            transform.Translate(movement);
        }

        if (forceMovement)
        {
            Vector2 movement = new Vector2(x, y);
            rb2d.AddForce(movement * speed);
        }

        if (velocityMovement)
        {
            Vector2 movement = new Vector2(x, y) * speed * Time.fixedDeltaTime;
            rb2d.velocity = movement;
        }

    }
}
