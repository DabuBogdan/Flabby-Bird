using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D theBirdBody;
    public float flapPower;
    public GameLogic logic;
    bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update()
    {
        if(Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
            theBirdBody.linearVelocity = Vector2.up * flapPower;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("1");
        if(collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("2");
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
