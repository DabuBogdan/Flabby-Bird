using UnityEngine;

public class DirtPopperScript : MonoBehaviour
{
    public GameObject dirtPrefab;
    public float spawnRate = 3;
    private float timer = 0;
    void Start()
    {
        SpawnDirt();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            SpawnDirt();
            timer = 0f;
        }
    }

    void SpawnDirt()
    {
        Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y);

        Instantiate(dirtPrefab, spawnPosition, Quaternion.identity);
    }
}
