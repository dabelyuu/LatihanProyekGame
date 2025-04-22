using System;
using UnityEngine;

public class objectMovement : MonoBehaviour
{

    public float speed = 3;
    private bool movingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction;

        if (movingRight)
        {
            direction = Vector2.right; // Move to the right
        }
        else
        {
            direction = Vector2.left; // Move to the left
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(gameObject.name + " touched a trigger!");
        movingRight = !movingRight;
    }
}
