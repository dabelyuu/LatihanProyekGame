using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Vector2 direction = Vector2.zero;

        // Get input from keyboard
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1; // Left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1; // Right
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1; // Up
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1; // Down
        }

        // Normalize to prevent faster diagonal movement
        direction = direction.normalized;

        // Move the player
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
