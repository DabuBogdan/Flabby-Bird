using UnityEngine;

public class PipePopperScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2;

    private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-2, 2);
        
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
