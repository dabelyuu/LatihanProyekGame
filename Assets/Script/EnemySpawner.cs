using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 10;
    private float timer=0;
    // public float heightOffset = 10;

    public float maxY = 5;
    public float minY = -5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        } else {
            SpawnEnemies();
            timer = 0;
        }
    }

    void SpawnEnemies(){
        
        //makes the enemies that spawned are random
        // float lowestPoint = transform.position.y - heightOffset;
        // float highestPoint = transform.position.y + heightOffset;

        float randomY = Random.Range(minY, maxY);
        Debug.Log("Spawned enemy at Y = " + randomY);


        Instantiate(enemy, new Vector2(transform.position.x, randomY), transform.rotation );
        
    }
}
