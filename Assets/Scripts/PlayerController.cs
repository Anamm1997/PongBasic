using UnityEngine;

[RequireComponent(typeof(MovementController))]
public class PlayerController : MonoBehaviour {

    MovementController mover;
	
	void Start () {
        mover = FindObjectOfType<MovementController>();	    
	}

    void FixedUpdate () {
        var input = new Vector2(0, Input.GetAxisRaw("Vertical"));
        mover.MoveIn(input);
    }
}
