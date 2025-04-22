using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(gameObject.name + "is destroyed");
        Destroy(gameObject); // Destroys this enemy
    }
}
