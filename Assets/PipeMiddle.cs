using UnityEngine;

public class PipeMiddleLogic : MonoBehaviour
{
    public GameLogic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.addScore();
    }
}
