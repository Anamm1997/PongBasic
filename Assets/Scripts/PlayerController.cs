using UnityEngine;

[RequireComponent(typeof(MovementController))]
public class PlayerController : MonoBehaviour {

    public bool isPlayerOne = false;
    public bool isPlayerTwo = false;
    public Transform Ball;

    MovementController mover;
	
	void Start () {
        mover = GetComponent<MovementController>();	    
	}

    void FixedUpdate () {
        if (isPlayerOne)
        {
            isPlayerTwo = false;
            Vector2 input = new Vector2(0, Input.GetAxisRaw("PlayerOne"));
            mover.MoveIn(input);
        }
        else if (isPlayerTwo)
        {
            isPlayerOne = false;
            Vector2 input = new Vector2(0, Input.GetAxisRaw("PlayerTwo"));
            mover.MoveIn(input);

        }
        else
        {
            float offsetY = Mathf.Clamp(Ball.transform.position.y - transform.position.y,-1,1);

            Vector2 input = new Vector2(0, offsetY);
            mover.MoveIn(input);
        }
        
    }

}
