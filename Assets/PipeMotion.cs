using UnityEngine;

public class PipeMotion : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -15f;
    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
