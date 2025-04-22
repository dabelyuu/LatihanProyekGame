using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3;
    private enum MoveDirection { Right, Down, Left, Up }
    private MoveDirection currentDirection = MoveDirection.Right;
    // private bool movingUp = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        // Set direction based on current state
        switch (currentDirection)
        {
            case MoveDirection.Right:
                direction = Vector2.right;
                break;
            case MoveDirection.Down:
                direction = Vector2.down;
                break;
            case MoveDirection.Left:
                direction = Vector2.left;
                break;
            case MoveDirection.Up:
                direction = Vector2.up;
                break;
        }

        // Move the player
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Player touched a trigger!");

        // Change direction in this order: Right → Down → Left → Up → Right...
        switch (currentDirection)
        {
            case MoveDirection.Right:
                currentDirection = MoveDirection.Down;
                break;
            case MoveDirection.Down:
                currentDirection = MoveDirection.Left;
                break;
            case MoveDirection.Left:
                currentDirection = MoveDirection.Up;
                break;
            case MoveDirection.Up:
                currentDirection = MoveDirection.Right;
                break;
        }
    }
}
