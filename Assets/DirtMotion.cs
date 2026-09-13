using UnityEngine;

public class DirtMotion : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -20;
    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
